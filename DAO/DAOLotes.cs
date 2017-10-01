using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOLotes
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOLotes(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelLotes modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO lote( Fk_carga, Fk_produto, qtd_produto, lote)" +
                    "VALUES (@carga, @produto, @quantidade, @lote)";
                cmd.Parameters.AddWithValue("@carga", modelo.Fk_carga);
                cmd.Parameters.AddWithValue("@produto", modelo.Fk_produto);
                cmd.Parameters.AddWithValue("@quantidade", modelo.qtd_produto);
                cmd.Parameters.AddWithValue("@lote", modelo.lote);

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
                cmd.CommandText = "DELETE FROM lote WHERE Fk_carga = @lote;";
                cmd.Parameters.AddWithValue("@lote", codigo);

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

        //METODO PARA BUSCAR DADOS DO BANCO LOTES
        public Queue<ModelCalculaLotes> LocalizarLotes(int valor)
        {
            Queue<ModelCalculaLotes> filaLotes = new Queue<ModelCalculaLotes>();

            try
            {
                DataTable tb = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Fk_produto, qtd_produto, lote FROM lote WHERE Fk_produto = '" + valor + "'", conexao.StringConexao);
                da.Fill(tb);
                conexao.Desconectar();

                foreach (DataRow item in tb.Rows)
                {
                    ModelCalculaLotes obj = new ModelCalculaLotes();

                    obj.Id_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                    obj.quantidade = Convert.ToDouble(item["qtd_produto"].ToString());
                    obj.lote = item["lote"].ToString();
                    obj.total = 0;
                    filaLotes.Enqueue(obj);
                }

                return filaLotes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //Fechar a conexão
                conexao.Desconectar();
            }

        }

        public DataTable RastreioLotes(string lote, string nome_produto, string data)      //BUSCA POR ID
         {
            DataTable tb = new DataTable();
            try
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Fk_carga 'CARGA', D.nome_cliente 'CLIENTE', B.dsc_produto 'PRODUTO', A.qtd_produto 'QUANTIDADE', A.lote 'LOTE', C.data_carregamento 'CARREGAMENTO' FROM lote AS A JOIN produto AS B JOIN carga AS C JOIN cliente AS D WHERE A.Fk_produto = B.Id_produto AND A.Fk_carga = C.Id_carga AND C.Fk_cliente = D.Id_cliente AND A.lote LIKE '%" + lote + "%' AND B.dsc_produto LIKE '%"+nome_produto+ "%' AND C.data_carregamento LIKE '%" + data + "%'", conexao.StringConexao);
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
