using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelUsuario
    {
        public ModelUsuario()
        {

        }

        public int Id_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string funcao { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
    }
}
