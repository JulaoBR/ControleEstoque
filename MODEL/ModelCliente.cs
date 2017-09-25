using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelCliente : ModelEstadoCidade
    {
        public ModelCliente()
        {

        }

        public int Id_cliente { get; set; }
        public string nome_cliente { get; set; }
        
    }
}
