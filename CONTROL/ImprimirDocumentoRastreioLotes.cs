using MODEL;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace CONTROL
{
    public class ImprimirDocumentoRastreioLotes : PrintDocument
    {
        private List<ModelRelatorioLotes> texto = new List<ModelRelatorioLotes>();
        private int numeroPagina;
        private int offset;

        public ImprimirDocumentoRastreioLotes(List<ModelRelatorioLotes> _texto)
        {
            this.Texto = _texto;
        }

        public List<ModelRelatorioLotes> Texto
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
