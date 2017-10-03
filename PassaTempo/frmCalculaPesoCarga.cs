using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCalculaPesoCarga : Form
    {
        public frmCalculaPesoCarga()
        {
            InitializeComponent();
            txtCodigoProduto.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto produto = new frmPesquisaProduto();
            produto.Show();
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCalculaPesoCarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmCalculaPesoCarga_Load(object sender, EventArgs e)
        {
            
        }
    }
}
