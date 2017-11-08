using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelRelatorioLotes
    {

        public ModelRelatorioLotes()
        {

        }

        public int Id_carga { set; get; }
        public string dsc_cliente { set; get; }
        public string dsc_produto { set; get; }
        public double quantidade { set; get; }
        public string lote { set; get; }
        public string carregamento { set; get; }
    }
}
