using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaEstado : PassaTempo.frmTelaDePesquisa
    {
        public int codigo = 0;

        public frmPesquisaEstado()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaEstado_Load(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridEstado.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmPesquisaEstado_Load(object sender, EventArgs e)
        {
            ControleCidadeEstado control = new ControleCidadeEstado();
            LimpaGrid();
            PreencheGrid(control.BuscaEstado(txtPesquisa.Text));
        }

        private void LimpaGrid()
        {
            gridEstado.DataSource = null;
            gridEstado.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridEstado.DataSource = tb;
        }
    }
}
