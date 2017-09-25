using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelProduto
    {

        public ModelProduto()
        {

        }

        public int Id_produto { get; set; }
        public string DscProduto { get; set; }
        public double qtd_minimo { get; set; }
        public double qtd_maximo { get; set; }
        public double qtd_estoque { get; set; }
        public int prazo_validade { get; set; }
        public double peso_liquido { get; set; }
        public double peso_bruto { get; set; }
        public string unidade_medida { get; set; }
        public int tipo_produto { get; set; }

        // 0 = materia prima
        // 1 = produto final
        

    }
}
