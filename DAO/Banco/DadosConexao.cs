using System;

namespace DAO
{
    public class DadosConexao
    {
        public static String StringConexao
        {
            get
            {
                return @"Data Source=.\BancoDados\BD_ProEstoque.sqlite;Version=3;";
            }
        }
    }
}
