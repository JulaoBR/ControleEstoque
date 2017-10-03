using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmRastreioDeLotes : PassaTempo.frmTelaDePesquisa
    {       

        public frmRastreioDeLotes()
        {
            InitializeComponent();         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscaDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void txtDataPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtDataPesquisa);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void gridRastreioLotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(gridRastreioLotes.Rows[e.RowIndex].Cells[0].Value);

                    frmCargaDetalhada frmDetalhada = new frmCargaDetalhada(codigo);
                    frmDetalhada.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma linha valida", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BuscaDados()
        {
            ControleLotes control = new ControleLotes();

            if (txtDataPesquisa.Text == string.Empty)
            {
                PreencheGrid(control.RastreioLotes(txtLote.Text, txtPesquisa.Text, null, txtNumeroCarga.Text));
            }
            else
            {
                PreencheGrid(control.RastreioLotes(txtLote.Text, txtPesquisa.Text, Convert.ToDateTime(txtDataPesquisa.Text).ToString("yyyy-MM-dd 00:00:00"), txtNumeroCarga.Text));
            }
        }

        private void LimpaGrid()
        {
            gridRastreioLotes.DataSource = null;
            gridRastreioLotes.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridRastreioLotes.DataSource = tb;
        }

        private void LimpaCampos()
        {
            txtDataPesquisa.Clear();
            txtLote.Clear();
            txtPesquisa.Clear();
            txtNumeroCarga.Clear();

            LimpaGrid();
        }


    }
}
