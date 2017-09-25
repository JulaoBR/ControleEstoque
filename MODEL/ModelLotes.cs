using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelLotes
    {
        public ModelLotes()
        {

        }

        public int Id_lote { get; set; }
        public int Fk_carga { get; set; }
        public int Fk_produto { get; set; }
        public double qtd_produto { get; set; }
        public string lote { get; set; }

    }  
}
