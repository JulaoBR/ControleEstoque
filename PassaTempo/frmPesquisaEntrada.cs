using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaEntrada : PassaTempo.frmTelaDePesquisa
    {

        public int codigo = 0;
        private int ajuste = 0;
        private int saida = 0;

        public frmPesquisaEntrada()
        {
            InitializeComponent();
        }

        private void frmPesquisaEntrada_Load(object sender, EventArgs e)
        {
            
        }        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rbAjuste_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAjuste.Checked)
            {
                ajuste = 1;
            }
            else
            {
                ajuste = 0;
            }
            
        }

        private void checkSaidas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaidas.Checked)
            {
                saida = 1;
            }
            else
            {
                saida = 0;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscaDados();
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void txtPesquisaData_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtPesquisaData);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void BuscaDados()
        {
            ControleRegistro registro = new ControleRegistro();

            PreencheGrid(registro.BuscaString(txtPesquisa.Text, txtPesquisaData.Text, txtLote.Text, ajuste, saida));
        }

        private void LimpaGrid()
        {
            gridEntrada.DataSource = null;
            gridEntrada.Refresh();            
        }

        private void PreencheGrid(DataTable tb)
        {            
            gridEntrada.DataSource = tb;                      
        }

        private void gridEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridEntrada.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaCampo()
        {
            txtLote.Clear();
            txtPesquisa.Clear();
            txtPesquisaData.Clear();

        }


    }
}
