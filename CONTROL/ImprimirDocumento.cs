﻿using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;


namespace CONTROL
{
    public class ImprimirDocumento : PrintDocument
    {
        private List<ModelCarga> texto = new List<ModelCarga>();
        private int numeroPagina;
        private int offset;

        public ImprimirDocumento(List<ModelCarga> _texto)
        {
            this.Texto = _texto;
        }


        public List<ModelCarga> Texto
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
