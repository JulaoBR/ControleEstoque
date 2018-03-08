using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelProdutoPedido : ModelProduto
    {
        public ModelProdutoPedido()
        {

        }

        public int Id_pedido { get; set; }
        public double quantidade { get; set; }
        public string validade { get; set; }
        public string lote { get; set; }
        public string cond_produto { get; set; }
        public string cond_entregador { get; set; }
        public string cond_veiculo { get; set; }
        public double temperatura { get; set; }
        public string laudo { get; set; }
        public string status { get; set; }
        public string resp_recebimento { get; set; }
    }
}
