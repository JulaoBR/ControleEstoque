using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelCalculaLotes
    {
        public ModelCalculaLotes()
        {

        }

        public int Id_produto { set; get; }
        public string lote { set; get; }
        public double quantidade { set; get; }
        public double total { set; get; }

    }
}
