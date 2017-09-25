using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaCidade : PassaTempo.frmTelaDePesquisa
    {
        public int codigo = 0;

        public frmPesquisaCidade()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCidade_Load(sender, e);
        }

        private void frmPesquisaCidade_Load(object sender, EventArgs e)
        {
            ControleCidadeEstado control = new ControleCidadeEstado();
            LimpaGrid();
            PreencheGrid(control.BuscaCidade(txtPesquisa.Text));
        }

        private void gridCidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridCidade.Rows[e.RowIndex].Cells[0].Value);
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
            gridCidade.DataSource = null;
            gridCidade.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridCidade.DataSource = tb;
        }
    }
}
