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
        public string data_pedito { get; set; }
        public string data_prevista { get; set; }
        public string data_entrega { get; set; }
        public int tipoPedido { get; set; }
        public string observcao { get; set; }
        public string resp_pedido { get; set; }
        public string data_hora { get; set; }
        public bool status { get; set; }
    }
}
