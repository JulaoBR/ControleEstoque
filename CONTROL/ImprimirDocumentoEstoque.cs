using MODEL;
using System.Collections.Generic;
using System.Drawing.Printing;


namespace CONTROL
{
    public class ImprimirDocumentoEstoque : PrintDocument
    {
        private List<ModelProduto> texto = new List<ModelProduto>();
        private int numeroPagina;
        private int offset;

        public ImprimirDocumentoEstoque(List<ModelProduto> _texto)
        {
            this.Texto = _texto;
        }

        public List<ModelProduto> Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        public int NumeroPagina
        {
            get { return numeroPagina; }
            set { numeroPagina = value; }
        }

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }
    }
}
