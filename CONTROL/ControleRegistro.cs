using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleRegistro
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAORegistro dao = new DAORegistro(cx);

        public ControleRegistro()
        {

        }

        public bool Inserir(List<ModelRegistro> lista)
        {
            ModelRegistro modelo;

            foreach (var item in lista)
            {
                modelo = new ModelRegistro();
                modelo.Fk_produto = item.Fk_produto;
                modelo.lote = item.lote;
                modelo.qtd_produto = item.qtd_produto;
                modelo.data_fabricacao = item.data_fabricacao;
                modelo.data_vencimento = item.data_vencimento;
                modelo.data_operacao = item.data_operacao;
                modelo.tipo_operacao = item.tipo_operacao;
                modelo.tipo_produto = item.tipo_produto;
                modelo.Fk_carga = item.Fk_carga;
                modelo.marcacao = item.marcacao;
                modelo.observacao = item.observacao;
                modelo.ajuste = item.ajuste;

                if (!dao.Inserir(modelo))
                {
                    MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }           
            return true;
        }

        public bool Atualizar(List<ModelRegistro> lista)
        {
            ModelRegistro modelo;

            foreach (var item in lista)
            {
                modelo = new ModelRegistro();

                if (item.Id_registro > 0)
                {
                    modelo.Id_registro = item.Id_registro;
                }

                modelo.Fk_produto = item.Fk_produto;
                modelo.lote = item.lote;
                modelo.qtd_produto = item.qtd_produto;
                modelo.data_fabricacao = item.data_fabricacao;
                modelo.data_vencimento = item.data_vencimento;
                modelo.data_operacao = item.data_operacao;
                modelo.tipo_operacao = item.tipo_operacao;
                modelo.tipo_produto = item.tipo_produto;
                modelo.Fk_carga = item.Fk_carga;
                modelo.marcacao = item.marcacao;

                if (!dao.Atualizar(modelo))
                {
                    MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public bool Excluir(int Id)
        {
            if (dao.Excluir2(Id))
            {
                return true;
            }
            return false;
        }

        public DataTable BuscaString(string produto, string data, string lote, int ajuste, int saida)
        {
            DAORegistro dao = new DAORegistro(cx);
            try
            {
                if (data == string.Empty)
                {
                    return dao.LocalizaPorString(produto, data, lote, ajuste, saida);
                }
                else
                {
                    return dao.LocalizaPorString(produto, Convert.ToDateTime(data).ToString("yyyy-MM-dd 00:00:00"), lote, ajuste, saida);
                }
            }
            catch
            {
                MessageBox.Show("Dados nao encontrados!","Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            
           
        }

        public DataTable BuscaInt(int valor)
        {
            DAORegistro dao = new DAORegistro(cx);
            return dao.LocalizaPorInt(valor);
        }

        public DataTable LocalizarDadosCarga(int valor)
        {
            DAORegistro dao = new DAORegistro(cx);
            return dao.LocalizarDadosCarga(valor);
        }

        public List<ModelRegistro> PreencheListaProdutos(int valor)
        {
            List<ModelRegistro> lista = new List<ModelRegistro>();

            var dt = LocalizarDadosCarga(valor);

            //LOOP PARA JOGAR O DATATABLE EM UMA LISTA
            foreach (DataRow item in dt.Rows)
            {
                ModelRegistro model = new ModelRegistro();
                model.Fk_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                model.dsc_produto = item["dsc_produto"].ToString();
                model.lote = item["lote"].ToString();
                model.qtd_produto = Convert.ToDouble(item["qtd_produto"].ToString());
                model.pesoLiquido += Convert.ToDouble(string.Format("{0:N}", Convert.ToDouble(item["peso_liquido"].ToString()) * Convert.ToDouble(item["qtd_produto"].ToString())));
                model.pesoBruto += Convert.ToDouble(string.Format("{0:N}", Convert.ToDouble(item["peso_bruto"].ToString()) * Convert.ToDouble(item["qtd_produto"].ToString())));
                                 
                lista.Add(model);
            }

            return lista;
        }
    }
}
