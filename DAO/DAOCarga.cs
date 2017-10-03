using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOCarga
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOCarga(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelCarga modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO carga(Id_carga, Fk_cliente, data_carregamento, nome_comprador)" +
                    "VALUES (@carga, @cliente, @data, @comprador)";
                cmd.Parameters.AddWithValue("@carga", modelo.Id_carga);
                cmd.Parameters.AddWithValue("@cliente", modelo.Fk_cliente);
                cmd.Parameters.AddWithValue("@data", modelo.data_carregamento);
                cmd.Parameters.AddWithValue("@comprador", modelo.nome_comprador);

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

       //ALTERAR VOU PENSAR SE COLOCO

        public bool Excluir(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM carga WHERE Id_carga = @carga;";
                cmd.Parameters.AddWithValue("@carga", codigo);

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
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_carga 'ID', B.nome_cliente 'CLIENTE', B.endereco 'ENDEREÇO', A.data_carregamento 'CARREGAMENTO', A.nome_comprador 'COMPRADOR' FROM carga AS A JOIN cliente AS B WHERE A.Fk_cliente = B.Id_cliente AND nome_cliente LIKE '%" +
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
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_carga 'ID', B.nome_cliente 'CLIENTE', B.endereco 'ENDEREÇO', A.data_carregamento 'CARREGAMENTO', A.nome_comprador 'COMPRADOR' FROM carga AS A JOIN cliente AS B WHERE A.Fk_cliente = B.Id_cliente AND Id_carga ='" +
                Id + "'", conexao.StringConexao))
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

        //BUSCA CARGA DETALHADA
        public DataTable LocalizarCargaDetalhada(int Id)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Fk_cliente, A.data_carregamento, A.nome_comprador, B.nome_cliente, B.endereco, C.nome_cidade, C.cep, D.nome_estado  FROM carga AS A JOIN cliente AS B JOIN cidade AS C JOIN estado AS D WHERE A.Fk_cliente = B.Id_cliente AND B.Id_cidade = C.Id_cidade AND B.Id_estado = D.Id_estado AND Id_carga = '" + Id + "'", conexao.StringConexao))
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
        public object VerificaCarga(int valor)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT Id_carga FROM carga WHERE Id_carga = @Id;";
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
