using DAO;
using MODEL;
using System.Data;
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
            if (dao.Inserir(modelo))
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na inserção do novo produto", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void Alterar(ModelProduto modelo)
        {

            DAOProduto dao = new DAOProduto(cx);
            if (dao.Alterar(modelo))
            {
                MessageBox.Show("Atualização realizada com sucesso!", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na atualização do produto", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void Excluir(int  codigo)
        {
            DAOProduto dao = new DAOProduto(cx);
            if (dao.Excluir(codigo))
            {
                MessageBox.Show("Item excluido", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscaString(string valor, int tipoProduto)
        {
            DAOProduto dao = new DAOProduto(cx);
            return dao.LocalizaPorString(valor, tipoProduto);
        }

        public DataTable BuscaPreencheComboBox()
        {
            DAOProduto dao = new DAOProduto(cx);
            return dao.PreencheComboBox();
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
