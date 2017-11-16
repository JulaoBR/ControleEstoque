using DAO;
using MODEL;
using System.Data;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleCidadeEstado
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOCidade dao = new DAOCidade(cx);
        private DAOEstado dao2 = new DAOEstado(cx);

        public ControleCidadeEstado()
        {

        }

        public void InserirCidade(ModelEstadoCidade modelo)
        {
            if (!dao.Inserir(modelo))
            {
                MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void InserirEstado(ModelEstadoCidade modelo)
        {
            if (!dao2.Inserir(modelo))
            {
                MessageBox.Show("Erro na inserção", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void AlterarCidade(ModelEstadoCidade modelo)
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

        public void AlterarEstado(ModelEstadoCidade modelo)
        {
            if (dao2.Alterar(modelo))
            {
                MessageBox.Show("Atualização realizada com sucesso!", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na atualização", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void ExcluirCidade(int codigo)
        {
            DAOCidade dao = new DAOCidade(cx);
            if (dao.Excluir(codigo))
            {
                MessageBox.Show("Item excluido", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirEstado(int codigo)
        {
            DAOEstado dao = new DAOEstado(cx);
            if (dao.Excluir(codigo))
            {
                MessageBox.Show("Item excluido", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscaCidade(string valor)
        {
            return dao.LocalizaPorString(valor);
        }

        public DataTable BuscaCidade(int Id)
        {
            return dao.LocalizarPorInt(Id);
        }

        public DataTable BuscaCidadeEstado(int Id)
        {
            return dao.LocalizarCidadesEstado(Id);
        }

        public DataTable BuscaEstado(string valor)
        {
            return dao2.LocalizaPorString(valor);
        }

        public DataTable BuscaEstado(int Id)
        {
            return dao2.LocalizarPorInt(Id);
        }

    }
}
