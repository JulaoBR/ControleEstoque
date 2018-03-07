using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadPedidosMateriaPrima : PassaTempo.frmCadastro
    {
        private List<ModelPedido> listaProduto = new List<ModelPedido>();

        public frmCadPedidosMateriaPrima()
        {
            InitializeComponent();
            gridProdutos.AutoGenerateColumns = false;
        }

        private void CarregaComboFornecedor()
        {
            ControleCliente control = new ControleCliente();

            cbFornecedor.DataSource = control.BuscaPreencheComboBox();
            cbFornecedor.DisplayMember = "nome_cliente";
            cbFornecedor.ValueMember = "Id_cliente";
            cbFornecedor.SelectedIndex = -1;
        }

        private void CarregaComboProduto()
        {
            ControleProduto control = new ControleProduto();

            cbProduto.DataSource = control.BuscaPreencheComboBox();
            cbProduto.DisplayMember = "dsc_produto";
            cbProduto.ValueMember = "Id_produto";
            cbProduto.SelectedIndex = -1;
            txtQuantidade.Focus();
        }

        private void frmCadPedidosMateriaPrima_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            CarregaComboFornecedor();
            CarregaComboProduto();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelPedido pedido = new ModelPedido();

                pedido.id_cliente = Convert.ToInt32(cbFornecedor.SelectedValue);
                pedido.data_pedito = Convert.ToDateTime(datePedido.Text).ToString("yyyy-MM-dd 00:00:00");
                pedido.data_prevista = Convert.ToDateTime(datePrevista.Text).ToString("yyyy-MM-dd 00:00:00");
                pedido.id_produto = Convert.ToInt32(cbProduto.SelectedValue);
                pedido.dsc_produto = cbProduto.Text;
                pedido.quantidade = Convert.ToDouble(txtQuantidade.Text);
                
                listaProduto.Add(pedido);
                AtualizaGrid();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos ","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizaGrid()
        {
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = listaProduto;
            gridProdutos.ClearSelection();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
        }
    }
}
