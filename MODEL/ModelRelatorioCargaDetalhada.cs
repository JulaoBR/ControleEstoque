using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelRelatorioCargaDetalhada : ModelEstadoCidade
    {

        public ModelRelatorioCargaDetalhada()
        {

        }

        public int cod_carga { get; set; }
        public int cod_cliente { get; set; }
        public string carregamento { get; set; }
        public string dsc_cliente { get; set; }
        public string comprador { get; set; }
        public double pesoLiquido { get; set; }
        public double pesoBruto { get; set; }
        public double totalCaixa { get; set; }
    }
}
