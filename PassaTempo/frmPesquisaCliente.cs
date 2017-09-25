using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaCliente : PassaTempo.frmTelaDePesquisa
    {
        public int codigo = 0;

        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente_Load(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaGrid();
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            ControleCliente control = new ControleCliente();
            LimpaGrid();
            PreencheGrid(control.BuscaString(txtPesquisa.Text));
        }

        private void gridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridCliente.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimpaGrid()
        {
            gridCliente.DataSource = null;
            gridCliente.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridCliente.DataSource = tb;
        }
    }
}
