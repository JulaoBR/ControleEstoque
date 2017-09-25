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
    public partial class frmCalculadora : Form
    {

        private int prazoValidade = 0;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculaValidade();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            CarregaComboProduto();
        }

        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {     
           if (e.KeyCode == Keys.Enter)
           {
               this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
           }      
        }

        private void cbNomeProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cbNomeProduto.ValueMember = "PRAZO VALIDADE";
                prazoValidade = Convert.ToInt32(cbNomeProduto.SelectedValue);
                this.LimpaCampo();
                txtPrazoValidade.Text = Convert.ToString(prazoValidade);
                txtDataFracricacao.Focus();
            }
            catch
            {
                return;
            }
        }


        //METODO DE CARREGAR OS ESTADOS NO COMBOBOX
        private void CarregaComboProduto()
        {
            ControleProduto controle = new ControleProduto();

            cbNomeProduto.DataSource = controle.BuscaString("",1);
            cbNomeProduto.DisplayMember = "PRODUTO";

            cbNomeProduto.SelectedIndex = -1;

        }


        private void LimpaCampo()
        {
            txtDataFracricacao.Clear();
            txtDataValidade.Clear();
            txtPrazoValidade.Clear();
        }

        private void CalculaValidade()
        {
            try
            {
                DateTime aux = Convert.ToDateTime(txtDataFracricacao.Text);
                txtDataValidade.Text = aux.AddDays(prazoValidade).ToString();
            }
            catch
            {
                return;
            }
        }

      
    }
}
