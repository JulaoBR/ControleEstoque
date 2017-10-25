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
    public partial class frmTelaConfiguracao : Form
    {
        public frmTelaConfiguracao()
        {
            InitializeComponent();
        }

        private void checkListaProdutos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkListaProdutos.Checked)
            {
                rbMateriaPrima.Enabled = true;
                rbProdutoFinal.Enabled = true;
            }
            else
            {
                //DESABILITA OS RADIONS BUTTONS
                rbMateriaPrima.Enabled = false;
                rbProdutoFinal.Enabled = false;

                //DESMARCA RADION BUTTONS
                rbMateriaPrima.Checked = false;
                rbProdutoFinal.Checked = false;
            }
        }




        private void Inicializa()
        {
            
        }

    }
}
