using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleProduto
    {
        private DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        public ControleProduto()
        {

        }

        public void Inserir(ModelProduto modelo)
        {

            DAOProduto dao = new DAOProduto(cx);
            if (!dao.Inserir(modelo))
            {
                MessageBox.Show("Erro na inserção do novo usuario", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void Alterar(ModelProduto modelo)
        {

            DAOProduto dao = new DAOProduto(cx);
            if (dao.Alterar(modelo))
            {
                MessageBox.Show("Erro na atualização do usuario", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public DataTable BuscaString(string valor, int tipoProduto)
        {
            DAOProduto dao = new DAOProduto(cx);
            return dao.LocalizaPorString(valor, tipoProduto);
        }

        public DataTable BuscaInt(int Id)
        {
            DAOProduto dao = new DAOProduto(cx);
            return dao.LocalizarPorInt(Id);
        }

        public object VerificaProduto(int Id)
        {
            DAOProduto dao = new DAOProduto(cx);
            return dao.VerificaProduto(Id);
        }
    }
}
