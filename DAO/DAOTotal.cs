using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOTotal
    {
        //ATRIBUTO PRIVADO
        private DAOConexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOTotal(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable BuscaRegistros(int id_produto, string data1, string data2, int tipo)
        {
            DataTable tb = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Id_registro, Fk_produto, qtd_produto, tipo_operacao " +
                "FROM registro  WHERE Fk_produto = '" + id_produto + "' AND tipo_operacao = '" + tipo + "'AND ajuste = 0 AND data_operacao BETWEEN '" + data1 + "' AND '" + data2 + "'", conexao.StringConexao);
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
