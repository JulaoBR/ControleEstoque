using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelRegistro
    {
        public ModelRegistro()
        {

        }

        public int Id_registro { get; set; }
        public int Fk_carga { get; set; }
        public int Id_produto { get; set; }
        public string Dsc_produto { get; set; }
        public string lote { get; set; }
        public double qtd_produto { get; set; }
        public string data_fabricacao { get; set; }
        public string data_vencimento { get; set; }
        public string data_operacao { get; set; }
        public int tipo_operacao { get; set; }
        public int tipo_produto { get; set; }
        public int marcacao { get; set; }
        public double pesoLiquido { get; set; }
        public double pesoBruto { get; set; }
        public int ajuste { get; set; }
        public string observacao { get; set; }
    }
}
