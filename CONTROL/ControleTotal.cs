using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    public class ControleTotal
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOTotal dao = new DAOTotal(cx);

        public ControleTotal()
        {

        }

        private  List<ModelRegistro> BuscaProdutos(string produto, int tipo)
        {
            List<ModelRegistro> Lista = new List<ModelRegistro>();
            ModelRegistro modelRegistro;
            ControleProduto controlProduto = new ControleProduto();

            var dt = controlProduto.BuscaString(produto, tipo);

            foreach (DataRow item in dt.Rows)
            {
                modelRegistro = new ModelRegistro();

                modelRegistro.Id_produto = Convert.ToInt32(item["ID"].ToString());
                modelRegistro.Dsc_produto = item["PRODUTO"].ToString();
                modelRegistro.qtd_produto = 0;

                Lista.Add(modelRegistro);
            }

            return Lista;
        }

        private List<ModelRegistro> BuscaRegistros(int produto, string data1, string data2, int tipo)
        {
            List<ModelRegistro> Lista = new List<ModelRegistro>();
            ModelRegistro modelRegistro;

            var dt = dao.BuscaRegistros(produto, data1, data2, tipo);

            foreach (DataRow item in dt.Rows)
            {
                modelRegistro = new ModelRegistro();

                modelRegistro.Id_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                modelRegistro.qtd_produto = Convert.ToDouble(item["qtd_produto"].ToString());
                modelRegistro.tipo_operacao = Convert.ToInt32(item["tipo_operacao"].ToString());

                Lista.Add(modelRegistro);
            }

            return Lista;
        }

        public List<ModelRegistro> CalculaTotal(string dsc_produto, string data1, string data2, int tipoProduto, int tipoOperacao)
        {
            var listaProdutos = BuscaProdutos(dsc_produto, tipoProduto);

            foreach (var item in listaProdutos)
            {
                var listaRegistro = BuscaRegistros(item.Id_produto, data1, data2, tipoOperacao);

                foreach (var item2 in listaRegistro)
                {
                    if (item2.tipo_operacao == 0)
                    {
                        item.qtd_produto += item2.qtd_produto;
                    }
                    else if(item2.tipo_operacao == 1)
                    {
                        item.qtd_produto += item2.qtd_produto;
                    }
                }
            }

            return listaProdutos;
        }
    }
}
