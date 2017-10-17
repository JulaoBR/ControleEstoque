using MODEL;
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
    }
}
