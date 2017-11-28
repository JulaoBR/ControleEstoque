using CONTROL;
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
    public partial class frmPesquisaTotal : PassaTempo.frmTelaDePesquisa
    {
        public frmPesquisaTotal()
        {
            InitializeComponent();
            gridTotal.AutoGenerateColumns = false;
        }

        private void frmPesquisaTotal_Load(object sender, EventArgs e)
        {
            ControleTotal control = new ControleTotal();

            gridTotal.DataSource = control.CalculaTotal(txtPesquisa.Text, "2017-10-27 00:00:00", "2017-11-28 00:00:00", 1, 0).ToList();

        }
    }
}
