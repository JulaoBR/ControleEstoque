using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaCaminhao : PassaTempo.frmTelaDePesquisa
    {

        public int codigo = 0;

        public frmPesquisaCaminhao()
        {
            InitializeComponent();
        }

        private void frmPesquisaCaminhao_Load(object sender, EventArgs e)
        {
            ControleVeiculos control = new ControleVeiculos();
            LimpaGrid();
            PreencheGrid(control.BuscaVeiculos(txtPesquisa.Text));
        }

        private void gridCaminhoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridCaminhoes.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!","Operação invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCaminhao_Load(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void LimpaGrid()
        {
            gridCaminhoes.DataSource = null;
            gridCaminhoes.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridCaminhoes.DataSource = tb;
        }
    }
}
