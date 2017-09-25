using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StringConexao
    {
        public static String strConexao
        {
            get
            {
                return @"Data Source=.\BancoDados\BD_ProEstoque.sqlite;Version=3;";
            }
        }
    }
}
