using MODEL;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOConfiguracao
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOConfiguracao(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public bool UpdadeConfiguracao(ModelConfiguracao model)
        {
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conexao.ObjetoConexao;
                    cmd.CommandText = "UPDATE configuracao SET lista_produto_menu = @lista, item_lista_produto_menu = @item, controle_botoes_menu = @botoes WHERE Id_tabela = @Id_tabela";
                    cmd.Parameters.AddWithValue("@lista", model.lista_produto_menu);
                    cmd.Parameters.AddWithValue("@item", model.item_lista_produto_menu);
                    cmd.Parameters.AddWithValue("@botoes", model.controle_botoes_menu);     cmd.Parameters.AddWithValue("@Id_tabela", model.Id_tabela);

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

        //METODO PARA BUSCAR DADOS DO BANCO LOTES
        public ModelConfiguracao BuscaValores()
        {
            ModelConfiguracao obj = new ModelConfiguracao();

            try
            {
                DataTable tb = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_tabela, lista_produto_menu, item_lista_produto_menu, controle_botoes_menu FROM configuracao", conexao.StringConexao);
                da.Fill(tb);
                conexao.Desconectar();

                foreach (DataRow item in tb.Rows)
                {                   
                    obj.Id_tabela = Convert.ToInt32(item["Id_tabela"].ToString());
                    obj.lista_produto_menu = Convert.ToInt32(item["lista_produto_menu"].ToString());
                    obj.item_lista_produto_menu = Convert.ToInt32(item["item_lista_produto_menu"].ToString());
                    obj.controle_botoes_menu = Convert.ToInt32(item["controle_botoes_menu"].ToString());          
                }

                return obj;
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

    }
}
