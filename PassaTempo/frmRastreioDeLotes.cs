using CONTROL;
using System;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmRastreioDeLotes : PassaTempo.frmTelaDePesquisa
    {
        private int seletor = 0;

        public frmRastreioDeLotes()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 1;
            txtDataPesquisa.ReadOnly = true;
            
        }

        private void brProduto_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 2;
            txtDataPesquisa.ReadOnly = true;
        }

        private void rbDataCarregamento_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 3;
            txtDataPesquisa.ReadOnly = false;
        }

        private void frmRastreioDeLotes_Load(object sender, EventArgs e)
        {

        }

        private void txtDataPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtDataPesquisa);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
