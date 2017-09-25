using CONTROL;
using System;
using System.Data;

namespace PassaTempo
{
    public partial class frmPesquisaUsuario : PassaTempo.frmTelaDePesquisa
    {
        public int codigo = 0;

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            ControleUsuario control = new ControleUsuario();
            LimpaGrid();
            PreencheGrid(control.BuscaUsuario(txtPesquisa.Text));
        }

        private void LimpaGrid()
        {
            gridTelaPesquisa.DataSource = null;
            gridTelaPesquisa.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridTelaPesquisa.DataSource = tb;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario_Load(sender, e);
        }

        private void gridTelaPesquisa_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(gridTelaPesquisa.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
