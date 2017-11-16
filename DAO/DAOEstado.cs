using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOEstado
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOEstado(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelEstadoCidade modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO estado(nome_estado)" +
                    "VALUES (@nome)";
                cmd.Parameters.AddWithValue("@nome", modelo.nome_estado);


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

        public bool Alterar(ModelEstadoCidade modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE estado SET nome_estado=@nome WHERE Id_estado = @Id_estado;";
                cmd.Parameters.AddWithValue("@nome", modelo.nome_estado);
                cmd.Parameters.AddWithValue("@Id_estado", modelo.Id_estado);

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
                cmd.CommandText = "DELETE FROM estado WHERE Id_estado = @cd_estado;";
                cmd.Parameters.AddWithValue("@cd_estado", codigo);

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
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM estado WHERE nome_estado LIKE '%" +
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

                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM estado WHERE Id_estado = '" + Id + "'", conexao.StringConexao);
                da.Fill(tb);
                conexao.Desconectar();
                return tb;
            }
            catch
            {
                return tb;
            }
        }
    }
}
