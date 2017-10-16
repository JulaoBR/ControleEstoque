using DAO;
using MODEL;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleVeiculos
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOVeiculos dao = new DAOVeiculos(cx);

        public ControleVeiculos()
        {

        }

        public void Inserir(ModelVeiculos modelo)
        {

            DAOVeiculos dao = new DAOVeiculos(cx);
            if (!dao.Inserir(modelo))
            {
                MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }
    }
}
