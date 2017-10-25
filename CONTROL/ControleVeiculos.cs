using DAO;
using MODEL;
using System.Data;
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

            if (modelo.dsc_veiculo == string.Empty || modelo.placa == string.Empty)
            {
                MessageBox.Show("Existem campos vazios!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!dao.Inserir(modelo))
                {
                    MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
            dao = null;
        }


        public void Alterar(ModelVeiculos modelo)
        {

            DAOVeiculos dao = new DAOVeiculos(cx);
            if (dao.Alterar(modelo))
            {
                MessageBox.Show("Erro na atualização", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public DataTable BuscaVeiculos(string valor)
        {
            DAOVeiculos dao = new DAOVeiculos(cx);
            return dao.LocalizaPorString(valor);
        }
    }
}
