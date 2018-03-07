using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOCliente
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOCliente(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelCliente modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO cliente(Id_cliente, Id_estado, Id_cidade, nome_cliente, endereco)" +
                    "VALUES (@cd_cliente, @estado, @cidade, @nome, @endereco)";
                cmd.Parameters.AddWithValue("@cd_cliente", modelo.Id_cliente);
                cmd.Parameters.AddWithValue("@estado", modelo.Id_estado);
                cmd.Parameters.AddWithValue("@cidade", modelo.Id_cidade);
                cmd.Parameters.AddWithValue("@nome", modelo.nome_cliente);
                cmd.Parameters.AddWithValue("@endereco", modelo.endereco);

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

        public bool Alterar(ModelCliente modelo)
        {
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conexao.ObjetoConexao;
                    cmd.CommandText = "UPDATE cliente SET Id_estado = @estado, Id_cidade = @cidade ,nome_cliente=@nome, endereco = @endereco WHERE Id_cliente = @Id_cliente;";
                    cmd.Parameters.AddWithValue("@estado", modelo.Id_estado);
                    cmd.Parameters.AddWithValue("@cidade", modelo.Id_cidade);
                    cmd.Parameters.AddWithValue("@nome", modelo.nome_cliente);
                    cmd.Parameters.AddWithValue("@endereco", modelo.endereco);
                    cmd.Parameters.AddWithValue("@Id_cliente", modelo.Id_cliente);

                    conexao.Conectar();
                    cmd.ExecuteNonQuery();

                    return true;
                }                 
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
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conexao.ObjetoConexao;
                    cmd.CommandText = "DELETE FROM cliente WHERE Id_Cliente = @cd_cliente;";
                    cmd.Parameters.AddWithValue("@cd_cliente", codigo);

                    conexao.Conectar();
                    cmd.ExecuteNonQuery();

                    return true;
                }                   
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
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_cliente AS 'ID', A.nome_cliente AS 'CLIENTE', B.nome_estado AS 'ESTADO', C.nome_cidade AS 'CIDADE', A.endereco AS 'ENDEREÇO', C.cep AS 'CEP' FROM cliente AS A JOIN estado AS B JOIN cidade AS C WHERE A.Id_estado = B.Id_estado AND A.Id_cidade = C.Id_cidade AND nome_cliente LIKE '%" +
                valor + "%'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    return tb;
                }                   
            }
            catch
            {
                return tb;
            }

        }


        public DataTable PreencheComboBox()
        {
            DataTable tb = new DataTable();
            try
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_cliente, nome_cliente FROM cliente ORDER BY nome_cliente", conexao.StringConexao))
                {
                    da.Fill(tb);
                    return tb;
                }
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

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_cliente, A.nome_cliente, B.nome_estado, C.nome_cidade, A.endereco, C.cep FROM cliente AS A JOIN estado AS B JOIN cidade AS C WHERE A.Id_estado = B.Id_estado AND A.Id_cidade = C.Id_cidade AND Id_cliente = '" + Id + "'", conexao.StringConexao))
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

        //METODO PARA RETORNAR SE JA EXISTE UM PRODUTO CADASTRATO
        public object VerificaCliente(int valor)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT Id_cliente FROM cliente WHERE Id_cliente = @Id;";
                cmd.Parameters.AddWithValue("@Id", valor);
                try
                {
                    conexao.Conectar();
                    return cmd.ExecuteScalar();
                }
                catch
                {
                    return null;
                }
                finally
                {
                    conexao.Desconectar();
                }
            }

        }
    }
}
