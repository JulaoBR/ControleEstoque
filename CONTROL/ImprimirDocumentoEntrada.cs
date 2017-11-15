using MODEL;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace CONTROL
{
    public class ImprimirDocumentoEntrada : PrintDocument
    {
        private List<ModelRegistro> texto = new List<ModelRegistro>();
        private int numeroPagina;
        private int offset;

        public ImprimirDocumentoEntrada(List<ModelRegistro> _texto)
        {
            this.Texto = _texto;
        }

        public List<ModelRegistro> Texto
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
