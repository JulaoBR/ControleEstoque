using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOPedido
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOPedido(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelPedido modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO pedido(Id_fornecedor dt_pedido, dt_prevista, observacao, tipoPedido, resp_pedido, dt_hora_pedido )" +
                    "VALUES (@fornecedor, @dtPedido, @dtPrevista, @observacao, @tipoPedido, @respPedido, @dataHora)";
                cmd.Parameters.AddWithValue("@fornecedor", modelo.id_cliente);
                cmd.Parameters.AddWithValue("@dtPedido", modelo.data_pedito);
                cmd.Parameters.AddWithValue("@dtPrevista", modelo.data_prevista);
                cmd.Parameters.AddWithValue("@observacao", modelo.observcao);
                cmd.Parameters.AddWithValue("@tipoPedido", modelo.tipoPedido);
                cmd.Parameters.AddWithValue("@respPedido", modelo.resp_pedido);
                cmd.Parameters.AddWithValue("@dataHora", modelo.data_hora);

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


        public DataTable LocalizaPedidos() //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_pedido, B.nome_cliente, A.dt_pedido, A.dt_prevista, A.dt_entrega, A.observacao, A.resp_pedido, A.dt_hora_pedido FROM pedido AS A JOIN cliente AS B WHERE A.Id_fornecedor = B.Id_cliente ORDER BY A.dt_prevista", conexao.StringConexao);
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
