using DAO;
using MODEL;
using System;
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
                MessageBox.Show("Atualização realizada com sucesso!", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na atualização", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;     
        }

        public void AlterarAtualizacaoSenha(ModelUsuario modelo)
        {
            DAOUsuario dao = new DAOUsuario(cx);
            if (dao.AlterarAtualizacao(modelo))
            {
                MessageBox.Show("Atualização realizada com sucesso!", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na atualização", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dao = null;
        }

        public void Excluir(int codigo)
        {
            DAOUsuario dao = new DAOUsuario(cx);
            if (dao.Excluir(codigo))
            {
                MessageBox.Show("Item excluido", "Operação Realizada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public bool VerificaUsuario(ModelUsuario modelo)
        {
            DAOUsuario dao = new DAOUsuario(cx);

            int valor = dao.ExeScalar(modelo);

            if (valor == 1)
            {
                return true;
            }else if (valor == 2)
            {
                MessageBox.Show("SENHA/LOGIN Incorretos", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else
            {
                MessageBox.Show("ERRO na operação", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        public DataTable BuscaUsuarioLogado(ModelUsuario modelo)
        {
            DAOUsuario dao = new DAOUsuario(cx);
            return dao.LocalizarUsuarioLogado(modelo);
        }

        //METODO PARA RESGITRAR AS ATIVIDADES DO USUARIO
        public static void RegistroAtividade(string usuario, string atividade)
        {
            //MONTA A MENSAGEM DE LOG 
            string msgDeLog = usuario + " " + atividade
                + " em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss");
            //CRIA UM OBJETO
            // E CHAMA O METODO ARQUIVO DA CLASSE DAO PARA CRIAÇÃO DO ARQUIVO
            DAOControleAcesso log = new DAOControleAcesso();
            log.arquivo(msgDeLog);
        }
    }
}
