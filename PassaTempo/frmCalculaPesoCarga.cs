using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCalculaPesoCarga : Form
    {
        private List<ModelRegistro> lista = new List<ModelRegistro>();

        public frmCalculaPesoCarga()
        {
            InitializeComponent();
            gridProdutos.AutoGenerateColumns = false;
            txtCodigoProduto.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto produto = new frmPesquisaProduto();
            produto.Show();
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCalculaPesoCarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmCalculaPesoCarga_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaSaida saida = new frmPesquisaSaida(3);
            ControleRegistro controlRegistro = new ControleRegistro();
            saida.ShowDialog();

            if (saida.codigo_carga != 0)
            {
                lista = controlRegistro.PreencheListaProdutos(saida.codigo_carga);
                PreencheGrid();
                AtualizaInfo();
            }
            else
            {
                return;
            }
        }


        private void PreencheGrid()
        {
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = lista;
        }

        private void AtualizaInfo()
        {
            double aux = 0, aux1 = 0, aux2 = 0;
            foreach (var item in lista)
            {
                aux += item.qtd_produto;
                aux1 += item.pesoLiquido;
                aux2 += item.pesoBruto;
            }
            lbTotalItens.Text = Convert.ToString(lista.Count);
            lbTotalCaixa.Text = Convert.ToString(string.Format("{0:N}", aux));
            txtPesoLiquido.Text = Convert.ToString(string.Format("{0:N}", aux1));
            lbPesoBruto.Text = Convert.ToString(string.Format("{0:N}", aux2));
        }
    }
}
