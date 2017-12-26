using MODEL;
using System;
using System.Data;
using System.Data.SQLite;


namespace DAO
{
    public class DAOUsuario
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOUsuario(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelUsuario modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO usuario(nome_usuario, funcao, login, senha)" +
                    "VALUES (@nome, @funcao, @login, @senha)";
                cmd.Parameters.AddWithValue("@nome", modelo.nome_usuario);
                cmd.Parameters.AddWithValue("@funcao", modelo.funcao);
                cmd.Parameters.AddWithValue("@login", modelo.login);
                cmd.Parameters.AddWithValue("@senha", modelo.senha);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public bool Alterar(ModelUsuario modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE usuario SET nome_usuario=@nome, funcao=@funcao, login=@login, senha=@senha WHERE Id_usuario = @Id_usuario;";
                cmd.Parameters.AddWithValue("@nome", modelo.nome_usuario);
                cmd.Parameters.AddWithValue("@funcao", modelo.funcao);
                cmd.Parameters.AddWithValue("@login", modelo.login);
                cmd.Parameters.AddWithValue("@senha", modelo.senha);
                cmd.Parameters.AddWithValue("@Id_usuario", modelo.Id_usuario);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public bool Excluir(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM usuario WHERE Id_usuario = @cd_usuario;";
                cmd.Parameters.AddWithValue("@cd_usuario", codigo);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch 
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }

        }

        public DataTable LocalizaPorString(string valor) //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_usuario 'ID USUARIO', nome_usuario 'NOME', funcao 'FUNÇÃO', login 'LOGIN', senha 'SENHA' FROM usuario WHERE nome_usuario LIKE '%" +
                valor + "%'", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }
            
        }      

        public DataTable LocalizarPorInt(int Id)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {
                
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM usuario WHERE Id_usuario = '" + Id + "'", conexao.StringConexao);
                da.Fill(tb);
                conexao.Desconectar();
                return tb;
            }
            catch
            {
                return tb;
            }
        }

        //METODO PARA FAZER O LOGIN
        public int ExeScalar(ModelUsuario user)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT login, senha FROM usuario WHERE login = @login AND senha = @senha;";
                cmd.Parameters.AddWithValue("@login", user.login);
                cmd.Parameters.AddWithValue("@senha", user.senha);
                try
                {
                    conexao.Conectar();
                    var comando = cmd.ExecuteScalar();

                    if (comando != null)
                    {
                        //dados coretos
                        return 1;
                    }
                    else
                    {
                        //2 = dados incorreta
                        return 2;
                    }
                }
                catch
                {       
                    //erro na autenticação            
                    return 3;
                }
                finally
                {
                    conexao.Desconectar();
                }
            }
        }

        //METODO PARA BUSCAR DADOS DO BANCO DE APENAS 1 REGISTRO
        public DataTable LocalizarUsuarioLogado(ModelUsuario user)
        {
            DataTable tb = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM usuario WHERE login = '" + user.login + "' AND senha = '" + user.senha + "'", conexao.StringConexao);
            da.Fill(tb);
            conexao.Desconectar();
            return tb;
        }
    }
}
