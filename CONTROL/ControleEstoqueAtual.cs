using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;

namespace CONTROL
{
    public class ControleEstoqueAtual
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        Queue<ModelCalculaLotes> filaLotes = new Queue<ModelCalculaLotes>();
        Queue<ModelCalculaLotes> filaRegistros = new Queue<ModelCalculaLotes>();

        public ControleEstoqueAtual()
        {

        }

        public static List<ModelProduto> BuscaDados(int ope, string valor)
        {
            try
            {
                double aux = 0, aux2 = 0;
                //LISTA PARA OS REGISTROS
                List<ModelRegistro> listaRegistro = new List<ModelRegistro>();
                ModelRegistro registro;
                DAORegistro dao = new DAORegistro(cx);
                ModelProduto modProduto;
                DAOProduto produto = new DAOProduto(cx);
                List<ModelProduto> Lista = new List<ModelProduto>();
                DataTable TabelaProdutos;

                TabelaProdutos = produto.LocalizaDadosParaCalcularEstoque(ope, valor);                           

                //LOOP PARA JOGAR O DATATABLE EM UMA LISTA
                foreach (DataRow item in TabelaProdutos.Rows)
                {
                    modProduto = new ModelProduto();
                    modProduto.Id_produto = Convert.ToInt32(item["ID PRODUTO"].ToString());
                    modProduto.DscProduto = item["PRODUTO"].ToString();
                    modProduto.qtd_minimo = Convert.ToInt32(item["QTD.MINIMO"].ToString());

                    Lista.Add(modProduto);
                }

                //LOOP PARA FAZER O CALCULO DE TODOS OS PRODUTOS
                foreach (var lisProdutos in Lista)
                {
                    listaRegistro.Clear();
                    aux = 0;
                    aux2 = 0;
                    DataTable estoque = dao.LocalizaRegistros(lisProdutos.Id_produto);
                    //LOOP PARA JOGAR O DATATABLE EM UMA LISTA
                    foreach (DataRow item in estoque.Rows)
                    {
                        registro = new ModelRegistro();
                        registro.Fk_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                        registro.qtd_produto = Convert.ToDouble(item["qtd_produto"].ToString());
                        registro.tipo_operacao = int.Parse(item["tipo_operacao"].ToString());

                        listaRegistro.Add(registro);
                    }
                    //estoque.Clear();
                    //FIM LOOP

                    //LOOP PARA SEPARAR A ENTRADA E SAIDA E FAZAER O CALCULO DE CADA UM
                    foreach (var item2 in listaRegistro)
                    {
                        if (item2.tipo_operacao == 0)//SE FOR ENTRADA
                        {
                            aux = aux + item2.qtd_produto;
                        }
                        if (item2.tipo_operacao == 1)//SE FOR SAIDA
                        {
                            aux2 = aux2 + item2.qtd_produto;
                        }
                    }

                    lisProdutos.qtd_estoque = aux - aux2;
                    //FIM DO LOOP
                }

                return Lista;

            }
            catch
            {
                return null;
            }           
        }   //RETORNA UMA LISTA COM TODOS OS PRODUTOS E SEU ESTOQUE ATUAL
      
        public static double CalculaEstoque(int id)
        {
            double aux = 0, aux2 = 0;
            //LISTA PARA OS REGISTROS
            List<ModelRegistro> lista = new List<ModelRegistro>();
            DAORegistro dao = new DAORegistro(cx);
            ModelRegistro registro = new ModelRegistro();

            lista.Clear();
            aux = 0;
            aux2 = 0;
            DataTable estoque = dao.LocalizaRegistros(id);
            //LOOP PARA JOGAR O DATATABLE EM UMA LISTA
            foreach (DataRow item in estoque.Rows)
            {
                registro = new ModelRegistro();
                registro.Fk_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                registro.qtd_produto = Convert.ToDouble(item["qtd_produto"].ToString());
                registro.tipo_operacao = int.Parse(item["tipo_operacao"].ToString());

                lista.Add(registro);
           }
           //FIM LOOP

                //LOOP PARA SEPARAR A ENTRADA E SAIDA E FAZAER O CALCULO DE CADA UM
                foreach (var item in lista)
                {
                    if (item.tipo_operacao == 0)//SE FOR ENTRADA
                    {
                        aux = aux + item.qtd_produto;
                    }
                    if (item.tipo_operacao == 1)//SE FOR SAIDA
                    {
                        aux2 = aux2 + item.qtd_produto;
                    }
                }

                return aux - aux2;
                //FIM DO LOOP
            }   //RETORNA UM PRODUTO COM SEU ESTOQUE ATUAL

        public Queue<ModelCalculaLotes> CalculaLotes(int cod_produto)
         {
            DAOLotes lote = new DAOLotes(cx);
            DAORegistro registro = new DAORegistro(cx);

            Queue<ModelCalculaLotes> filaAux = new Queue<ModelCalculaLotes>();

            filaLotes = lote.LocalizarLotes(cod_produto);               //SAIDAS DOS PRODUTOS
            filaRegistros = registro.LocalizarRegistro(cod_produto);    //ENTRADAS DOS PRODUTOS

            foreach (var item in filaRegistros)
            {
                foreach (var item2 in filaLotes)
                {
                    if (item2.lote.Equals(item.lote))
                    {
                        item.total += item2.quantidade;
                    }
                }

                if (item.total < item.quantidade)
                {
                    item.restante = item.quantidade - item.total;
                    filaAux.Enqueue(item);
                }
            }

            return filaAux;
        }

        public static List<ModelProduto> BuscaProdutoEstoqueMinimo(List<ModelProduto> lista)
        {
            List<ModelProduto> listaAux = new List<ModelProduto>();

            foreach (var item in lista)
            {
                if (item.qtd_estoque < item.qtd_minimo)
                {
                    listaAux.Add(item);
                } 
            }

            return listaAux;
        }

       }
    }

