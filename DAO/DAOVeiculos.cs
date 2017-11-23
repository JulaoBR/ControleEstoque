using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOVeiculos
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOVeiculos(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelVeiculos modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO veiculos(dsc_veiculo, tara, lotacao, placa)" +
                    "VALUES (@nome, @tara, @lotacao, @placa)";
                cmd.Parameters.AddWithValue("@nome", modelo.dsc_veiculo);
                cmd.Parameters.AddWithValue("@tara", modelo.tara);
                cmd.Parameters.AddWithValue("@lotacao", modelo.lotacao);
                cmd.Parameters.AddWithValue("@placa", modelo.placa);

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


        public bool Alterar(ModelVeiculos modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE veiculos SET dsc_veiculo=@nome, tara=@tara, lotacao=@lotacao, placa=@placa WHERE Id_veiculo = @Id_veiculo;";
                cmd.Parameters.AddWithValue("@nome", modelo.dsc_veiculo);
                cmd.Parameters.AddWithValue("@tara", modelo.tara);
                cmd.Parameters.AddWithValue("@lotacao", modelo.lotacao);
                cmd.Parameters.AddWithValue("@placa", modelo.placa);
                cmd.Parameters.AddWithValue("@Id_veiculo", modelo.Id_veiculo);

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
                cmd.CommandText = "DELETE FROM veiculos WHERE Id_veiculo = @cd_veiculo;";
                cmd.Parameters.AddWithValue("@cd_veiculo", codigo);

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
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_veiculo 'ID', dsc_veiculo 'NOME', tara 'TARA', lotacao 'LOTAÇÃO', placa 'PLATA' FROM veiculos WHERE dsc_veiculo LIKE '%" +
                valor + "%'", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }

        public DataTable LocalizaPorInt(int valor) //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_veiculo 'ID', dsc_veiculo 'NOME', tara 'TARA', lotacao 'LOTAÇÃO', placa 'PLACA' FROM veiculos WHERE Id_veiculo = '"+valor+"' ", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }
    }
}
