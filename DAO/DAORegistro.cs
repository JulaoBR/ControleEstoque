using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DAO
{
    public class DAORegistro
    {
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAORegistro(DAOConexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelRegistro modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO registro(Fk_produto, lote, qtd_produto, data_fabricacao, data_vencimento, data_operacao, tipo_operacao, tipo_produto, Fk_carga, marcacao, ajuste, observacao)" +
                    "VALUES (@produto, @lote, @quantidade, @fabricacao, @vencimento, @operacao, @tipoOperacao, @tipoProduto, @carga, @marcacao, @ajuste, @observacao)";
                cmd.Parameters.AddWithValue("@produto", modelo.Id_produto);
                cmd.Parameters.AddWithValue("@lote", modelo.lote);
                cmd.Parameters.AddWithValue("@quantidade", modelo.qtd_produto);
                cmd.Parameters.AddWithValue("@fabricacao", modelo.data_fabricacao);
                cmd.Parameters.AddWithValue("@vencimento", modelo.data_vencimento);
                cmd.Parameters.AddWithValue("@operacao", modelo.data_operacao);
                cmd.Parameters.AddWithValue("@tipoOperacao", modelo.tipo_operacao);
                cmd.Parameters.AddWithValue("@tipoProduto", modelo.tipo_produto);
                cmd.Parameters.AddWithValue("@carga", modelo.Fk_carga);
                cmd.Parameters.AddWithValue("@marcacao", modelo.marcacao);
                cmd.Parameters.AddWithValue("@ajuste", modelo.ajuste);
                cmd.Parameters.AddWithValue("@observacao", modelo.observacao);

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
       
        //METODO DE ATUALIZAR NO BANCO OS DADOS DO USUARIO
        public bool Atualizar(ModelRegistro modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE registro SET Fk_produto = @produto, lote = @lote, qtd_produto = @quantidade, data_fabricacao = @fabricacao, data_vencimento = @vencimento, data_operacao = @operacao, tipo_operacao = @tipoOperacao, tipo_produto = @tipoProduto, Fk_carga = @carga, marcacao = @marcacao, ajuste = @ajuste, observacao = @observacao WHERE Id_registro = @IdRegistro";
                cmd.Parameters.AddWithValue("@produto", modelo.Id_produto);
                cmd.Parameters.AddWithValue("@lote", modelo.lote);
                cmd.Parameters.AddWithValue("@quantidade", modelo.qtd_produto);
                cmd.Parameters.AddWithValue("@fabricacao", modelo.data_fabricacao);
                cmd.Parameters.AddWithValue("@vencimento", modelo.data_vencimento);
                cmd.Parameters.AddWithValue("@operacao", modelo.data_operacao);
                cmd.Parameters.AddWithValue("@tipoOperacao", modelo.tipo_operacao);
                cmd.Parameters.AddWithValue("@tipoProduto", modelo.tipo_produto);
                cmd.Parameters.AddWithValue("@carga", modelo.Fk_carga);
                cmd.Parameters.AddWithValue("@marcacao", modelo.marcacao);
                cmd.Parameters.AddWithValue("@ajuste", modelo.ajuste);
                cmd.Parameters.AddWithValue("@observacao", modelo.observacao);
                cmd.Parameters.AddWithValue("@IdRegistro", modelo.Id_registro);

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
                cmd.CommandText = "DELETE FROM registro WHERE Id_registro = @registro;";
                cmd.Parameters.AddWithValue("@registro", codigo);

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

        public bool Excluir2(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM registro WHERE Fk_carga = @registro;";
                cmd.Parameters.AddWithValue("@registro", codigo);

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

        public DataTable LocalizaPorString(string produto, string data, string lote, int ajuste, int saida) //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_registro 'ID', B.dsc_produto 'PRODUTO', A.lote 'LOTE', A.qtd_produto 'QUANTIDADE', A.data_fabricacao 'FABRICAÇÃO', A.data_vencimento 'VENCIMENTO', A.data_operacao 'PRODUÇÃO', A.observacao 'OBSERVAÇÃO' FROM registro AS A JOIN produto AS B WHERE A.Fk_produto = B.Id_produto AND B.dsc_produto LIKE '%" +
                produto + "%' AND A.data_operacao LIKE '%"+data+"%' AND A.lote LIKE '%"+lote+"%' AND A.ajuste LIKE '%"+ajuste+"%' AND A.tipo_operacao LIKE '%"+saida+"%' ", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }

        public DataTable Localiza2Lotes(string produto, string data, string lote, string lote2, int ajuste, int saida) //BUSCA COM STRING
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_registro 'ID', B.dsc_produto 'PRODUTO', A.lote 'LOTE', A.qtd_produto 'QUANTIDADE', A.data_fabricacao 'FABRICAÇÃO', A.data_vencimento 'VENCIMENTO', A.data_operacao 'PRODUÇÃO', A.observacao 'OBSERVAÇÃO' FROM registro AS A JOIN produto AS B WHERE A.Fk_produto = B.Id_produto AND B.dsc_produto LIKE '%" +
                produto + "%' AND A.data_operacao LIKE '%" + data + "%' AND A.lote BETWEEN '" + lote + "' AND '"+lote2+"' AND A.ajuste LIKE '%" + ajuste + "%' AND A.tipo_operacao LIKE '%" + saida + "%' ORDER BY A.lote", conexao.StringConexao);
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
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Id_registro 'ID REGIS', A.Fk_produto 'ID PRO', B.dsc_produto 'PRODUTO', A.lote 'LOTE', A.qtd_produto 'QUANTIDADE', A.data_fabricacao 'FABRICAÇÃO', A.data_vencimento 'VENCIMENTO', A.data_operacao 'OPERAÇÃO', A.tipo_operacao 'TIPO.OPER', A.tipo_produto, A.marcacao 'MARCAÇÃO', A.ajuste 'AJUSTE', A.observacao 'OBSERVAÇÃO' FROM registro AS A JOIN produto AS B WHERE A.Fk_produto = B.Id_produto AND A.tipo_operacao = 0 AND A.Id_registro ='" +
                valor + "'", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }

        public DataTable LocalizaRegistros(int id) 
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_registro, Fk_produto, qtd_produto, tipo_operacao FROM registro  WHERE Fk_produto = '" + id + "'", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }

        public DataTable LocalizarDadosCarga(int id)
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.Fk_produto, B.dsc_produto, B.peso_liquido, B.peso_bruto, A.lote, A.qtd_produto FROM registro AS A JOIN produto AS B WHERE A.Fk_produto = B.Id_produto AND A.Fk_carga = '" + id + "'", conexao.StringConexao);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return tb;
            }

        }

        //METODO PARA BUSCAR DADOS DO BANCO REGISTROS
        public Queue<ModelCalculaLotes> LocalizarRegistro(int valor)
        {
            Queue<ModelCalculaLotes> filaRegistros = new Queue<ModelCalculaLotes>();

            try
            {
                DataTable tb = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Fk_produto, lote, qtd_produto FROM registro WHERE Fk_produto = '" + valor + "' AND tipo_operacao = 0 AND marcacao = 0", conexao.StringConexao);
                da.Fill(tb);
                conexao.Desconectar();

                foreach (DataRow item in tb.Rows)
                {
                    ModelCalculaLotes obj = new ModelCalculaLotes();

                    obj.Id_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                    obj.lote = item["lote"].ToString();
                    obj.quantidade = Convert.ToDouble(item["qtd_produto"].ToString());
                    obj.total = 0;

                    filaRegistros.Enqueue(obj);
                }

                return filaRegistros;
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
