using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelPedido
    {

        public ModelPedido() { 
}

        public int Id_pedito { get; set; }
        public int id_cliente { get; set; }
        public string nome_cliente { get; set; }
        public int id_produto { get; set; }
        public string dsc_produto { get; set; }
        public string data_pedito { get; set; }
        public string data_prevista { get; set; }
        public string data_entrega { get; set; }
        public string contato { get; set; }
        public double quantidade { get; set; }
        public double vl_unitario { get; set; }
    }
}
