using DAO;
using MODEL;
using System.Data;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleUsuario
    {
        private DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);

        public ControleUsuario()
        {
            
        }

        public void Inserir(ModelUsuario modelo)
        {
            
                DAOUsuario dao = new DAOUsuario(cx);
            if (!dao.Inserir(modelo))
            {
                MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;                                                    
        }

        public void Alterar(ModelUsuario modelo)
        {
            
            DAOUsuario dao = new DAOUsuario(cx);
            if (dao.Alterar(modelo))
            {
                MessageBox.Show("Erro na atualização", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;     
        }

        public DataTable BuscaUsuario(string valor)
        {
            DAOUsuario dao = new DAOUsuario(cx);
            return dao.LocalizaPorString(valor);
        }

        public DataTable BuscaUsuario(int Id)
        {
            DAOUsuario dao = new DAOUsuario(cx);
            return dao.LocalizarPorInt(Id);
        }
    }
}
