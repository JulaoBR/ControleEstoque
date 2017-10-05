using MODEL;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAOProduto
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOProduto(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelProduto modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO produto(dsc_produto, qtd_minimo, qtd_maximo, prazo_validade, peso_liquido, peso_bruto, unidade_medida, tipo_produto)" +
                    "VALUES (@descricao, @minimo, @maximo, @prazo, @pesoLiquido, @pesoBruto, @unidade, @tipo)";
                cmd.Parameters.AddWithValue("@descricao", modelo.DscProduto);
                cmd.Parameters.AddWithValue("@unidade", modelo.unidade_medida);
                cmd.Parameters.AddWithValue("@pesoBruto", modelo.peso_bruto);
                cmd.Parameters.AddWithValue("@pesoLiquido", modelo.peso_liquido);
                cmd.Parameters.AddWithValue("@prazo", modelo.prazo_validade);
                cmd.Parameters.AddWithValue("@minimo", modelo.qtd_minimo);
                cmd.Parameters.AddWithValue("@maximo", modelo.qtd_maximo);
                cmd.Parameters.AddWithValue("@tipo", modelo.tipo_produto);


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

        public bool Alterar(ModelProduto modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE produto SET dsc_produto = @produto, qtd_minimo = @minimo, qtd_maximo = @maximo, prazo_validade = @prazo, peso_liquido = @liquido, peso_bruto = @bruto, unidade_medida = @unidade, tipo_produto = @tipo WHERE Id_produto = @Id_produto;";
                cmd.Parameters.AddWithValue("@produto", modelo.DscProduto);
                cmd.Parameters.AddWithValue("@minimo", modelo.qtd_minimo);
                cmd.Parameters.AddWithValue("@maximo", modelo.qtd_maximo);
                cmd.Parameters.AddWithValue("@prazo", modelo.prazo_validade);
                cmd.Parameters.AddWithValue("@liquido", modelo.peso_liquido);
                cmd.Parameters.AddWithValue("@bruto", modelo.peso_bruto);
                cmd.Parameters.AddWithValue("@unidade", modelo.unidade_medida);
                cmd.Parameters.AddWithValue("@tipo", modelo.tipo_produto);
                cmd.Parameters.AddWithValue("@Id_produto", modelo.Id_produto);

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
                cmd.CommandText = "DELETE FROM produto WHERE Id_produto = @Id_produto;";
                cmd.Parameters.AddWithValue("@Id_produto", codigo);

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

        public DataTable LocalizaPorString(string valor,int tipoProduto) //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_produto AS 'ID', dsc_produto AS 'PRODUTO', qtd_minimo AS 'QTD.MINIMO', qtd_maximo AS 'QTD.MAXIMO', prazo_validade AS 'PRAZO', peso_liquido AS 'PESO LIQ', peso_bruto AS 'PESO BT', unidade_medida AS 'UNI.MEDIDA' FROM produto WHERE dsc_produto LIKE '%" +
                valor + "%' AND tipo_produto = '"+tipoProduto+"'", conexao.StringConexao);
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

                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM produto WHERE Id_produto = '" + Id + "'", conexao.StringConexao);
                da.Fill(tb);
                conexao.Desconectar();
                return tb;
            }
            catch
            {
                return tb;
            }
        }

        public DataTable LocalizaDadosParaCalcularEstoque(int tipo, string valor) //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_produto AS 'ID PRODUTO', dsc_produto AS 'PRODUTO', qtd_minimo AS 'QTD.MINIMO', qtd_maximo AS 'QTD.MAXIMO', prazo_validade AS 'PRAZO.VAL', peso_liquido AS 'PESO LIQ', peso_bruto AS 'PESO BT', unidade_medida AS 'UNI.MEDIDA' FROM produto WHERE tipo_produto = '"+tipo+"' AND dsc_produto LIKE '%" +
                valor + "%'", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }

        //METODO PARA RETORNAR SE JA EXISTE UM PRODUTO CADASTRATO
        public object VerificaProduto(int valor)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT Id_produto FROM produto WHERE Id_produto = @Id;";
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
