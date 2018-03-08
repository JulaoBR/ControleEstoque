using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOCidade
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOCidade(DAOConexao cx)
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
                cmd.CommandText = "INSERT INTO cidade(Fk_estado, nome_cidade, cep)" +
                    "VALUES (@estado, @nome, @cep)";
                cmd.Parameters.AddWithValue("@nome", modelo.nome_cidade);
                cmd.Parameters.AddWithValue("@estado", modelo.Id_estado);
                cmd.Parameters.AddWithValue("@cep", modelo.cep);

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
                cmd.CommandText = "UPDATE cidade SET nome_cidade=@nome, Fk_estado=@estado, cep=@cep WHERE Id_cidade = @Id_cidade;";
                cmd.Parameters.AddWithValue("@nome", modelo.nome_cidade);
                cmd.Parameters.AddWithValue("@estado", modelo.Id_estado);
                cmd.Parameters.AddWithValue("@cep", modelo.cep);
                cmd.Parameters.AddWithValue("@Id_cidade", modelo.Id_cidade);

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
                cmd.CommandText = "DELETE FROM cidade WHERE Id_cidade = @cd_cidade;";
                cmd.Parameters.AddWithValue("@cd_cidade", codigo);

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
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_cidade, A.Fk_estado, B.nome_estado, A.nome_cidade, A.cep FROM cidade AS A INNER JOIN estado AS B WHERE A.Fk_estado = B.Id_estado AND nome_cidade LIKE '%" +
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
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_cidade, A.Fk_estado, B.nome_estado, A.nome_cidade, A.cep FROM cidade AS A INNER JOIN estado AS B WHERE A.Fk_estado = B.Id_estado AND Id_cidade = '" + Id + "'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }                   
            }
            catch
            {
                return tb;
            }
        }

        public DataTable LocalizarCidadesEstado(int Id)      //BUSCA AS CIDADES DE UM ESTADO ESPECIFICO
        {
            DataTable tb = new DataTable();
            try
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM cidade WHERE Fk_estado = '" + Id + "' ORDER BY nome_cidade", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch
            {
                return tb;
            }
        }

       
    }
}
