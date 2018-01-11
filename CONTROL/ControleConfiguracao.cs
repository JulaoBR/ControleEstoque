using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleConfiguracao
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOConfiguracao dao = new DAOConfiguracao(cx);

        public ControleConfiguracao()
        {

        }

        public void UpdadeConfiguracao(ModelConfiguracao model)
        {
            DAOConfiguracao dao = new DAOConfiguracao(cx);

            if (dao.UpdadeConfiguracao(model))
            {
                MessageBox.Show("Configuração salva com sucesso! Reinicie o sistema para as novas configurações serem atualizadas","CONFIGURAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Erro ao salvar suas configurações!", "CONFIGURAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ModelConfiguracao BuscaValor()
        {
            DAOConfiguracao dao = new DAOConfiguracao(cx);

            return dao.BuscaValores();
        }
    }
}
