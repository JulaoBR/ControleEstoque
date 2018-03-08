using CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmPesquisaPedidos : PassaTempo.frmTelaDePesquisa
    {
        public frmPesquisaPedidos()
        {
            InitializeComponent();
        }

        private void frmPesquisaPedidos_Load(object sender, EventArgs e)
        {
            ControlePedido control = new ControlePedido();

            gridPedidos.DataSource = null;
            gridPedidos.DataSource = control.BuscaPedidos();
        }
    }
}
