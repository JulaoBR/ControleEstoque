using DAO;
using MODEL;
using System.Data;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleCliente
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOCliente dao = new DAOCliente(cx);

        public ControleCliente()
        {

        }

        public bool Inserir(ModelCliente modelo)
        {         
            if (!dao.Inserir(modelo))
            {
                MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dao = null;
            return true;
        }

        public void Alterar(ModelCliente modelo)
        {
            if (dao.Alterar(modelo))
            {
                MessageBox.Show("Atualização realizada com sucesso!", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na atualização", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void Excluir(int codigo)
        {
            try
            {
                DAOCliente control = new DAOCliente(cx);
                if (control.Excluir(codigo))
                {
                    MessageBox.Show("Item excluido", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro na exclusão", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro na exclusão", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscaString(string valor)
        {
            return dao.LocalizaPorString(valor);
        }

        public DataTable BuscaInt(int Id)
        {
            return dao.LocalizarPorInt(Id);
        }

        public object VerificaCliente(int Id)
        {
            return dao.VerificaCliente(Id);
        }
    }
}
