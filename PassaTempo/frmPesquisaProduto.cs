using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaProduto : PassaTempo.frmTelaDePesquisa
    {
        public int codigo = 0;
        private int tipoProduto;

        public frmPesquisaProduto(int tipoProduto)
        {
            InitializeComponent();
            this.tipoProduto = tipoProduto;
        }

        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridProduto.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto_Load(sender, e);
        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            ControleProduto control = new ControleProduto();
            LimpaGrid();

            if (rbProdutoFinal.Checked)
            {
                tipoProduto = 1;
            } else if (rbMateriaPrima.Checked)
            {
                tipoProduto = 0;
            }

            PreencheGrid(control.BuscaString(txtPesquisa.Text, tipoProduto));
        }

        private void LimpaGrid()
        {
            gridProduto.DataSource = null;
            gridProduto.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridProduto.DataSource = tb;
        }
    }
}
