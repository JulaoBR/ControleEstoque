using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadPedidosMateriaPrima : PassaTempo.frmCadastro
    {
        private List<ModelProdutoPedido> listaProduto = new List<ModelProdutoPedido>();
        private int tipoOperação = 0; // 1 = PEDIDO INTERNO - 2 = PEDIDO DE COMPRAS
        private string userLogado;
        private ModelPedido pedido;

        public frmCadPedidosMateriaPrima(string userLogado)
        {
            InitializeComponent();
            gridProdutos.AutoGenerateColumns = false;
            this.userLogado = userLogado;
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


        private void PreenchePedido()
        {
            try
            {
                pedido = new ModelPedido();

                pedido.id_cliente = Convert.ToInt32(cbFornecedor.SelectedValue);
                pedido.data_pedito = Convert.ToDateTime(datePedido.Text).ToString("yyyy-MM-dd 00:00:00");
                pedido.data_prevista = Convert.ToDateTime(datePrevista.Text).ToString("yyyy-MM-dd 00:00:00");
                pedido.tipoPedido = tipoOperação;
                pedido.observcao = txtObservacao.Text;
                pedido.data_hora = Convert.ToString(DateTime.Now);
                pedido.resp_pedido = userLogado;
                pedido.status = false;

            }
            catch
            {
                MessageBox.Show("Produto ja selecionado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificaLista(Convert.ToInt32(cbProduto.SelectedValue)))
                {
                    ModelProdutoPedido produto = new ModelProdutoPedido();

                    produto.Id_produto = Convert.ToInt32(cbProduto.SelectedValue);
                    produto.DscProduto = cbProduto.Text;
                    produto.quantidade = Convert.ToDouble(txtQuantidade.Text);
                
                    listaProduto.Add(produto);
                    AtualizaGrid();
                    txtQuantidade.Clear();
                    cbProduto.SelectedIndex = -1;
                    txtObservacao.Clear();
                }
                else
                {
                    MessageBox.Show("Produto ja selecionado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
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

        private bool VerificaLista(int id_produto)
        {
            //RETORNA TRUE OU FALSE< SE O PRODUTO JA ESTIVER NA LISTA DE COMPRA
            //return lisProduto.Any(l => l.Cd_produto == cd);
            foreach (var item in listaProduto)
            {
                if (id_produto == item.Id_produto)
                {
                    return true;
                }
            }
            return false;
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
            ControlePedido control = new ControlePedido();
            PreenchePedido();

            if (listaProduto.Count > 0)
            {
                if (VerificaCampo())
                {
                    control.Inserir(pedido);
                    panel2.Enabled = false;
                    LimpaCampo();
                    this.inicioBotoes();
                    MessageBox.Show("Pedido Salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Dados incompletos para salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {             
                MessageBox.Show("Sem produtos para salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                
        }

        private bool VerificaCampo()
        {
            if(cbFornecedor.Text == string.Empty && cbTipoOperacao.Text == string.Empty && cbProduto.Text == string.Empty && txtQuantidade.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoOperacao.Text.Equals("PEDIDO INTERNO"))
            {
                tipoOperação = 1;
            }else if (cbTipoOperacao.Text.Equals("PEDIDO DE COMPRA"))
            {
                tipoOperação = 2;
            }
        }

        private void gridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codigo = Convert.ToInt32(gridProdutos.Rows[e.RowIndex].Cells[0].Value);

                //PERGUNTA SE DESEJA CADASTRAR UM NOVO CLIENTE
                DialogResult d = MessageBox.Show("Deseja remover este ITEM?", "AVISO!!", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    RemoverItemListaLotes(codigo);
                    AtualizaGrid();
                }
                else
                {
                    return;
                }
            }
        }

        //METODO PARA REMOVER ITENS DA LISTA DE LOTES
        private void RemoverItemListaLotes(int codigo)
        {
            foreach (var item in listaProduto)
            {
                if (codigo == item.Id_produto)
                {
                    //REMOVE O PRODUTO SELECIONADO
                    listaProduto.Remove(item);
                    return;
                }
            }
        }

        private void LimpaCampo()
        {
            txtObservacao.Clear();
            txtQuantidade.Clear();
            cbFornecedor.SelectedIndex = -1;
            cbProduto.SelectedIndex = -1;
            cbTipoOperacao.SelectedIndex = -1;
            gridProdutos.DataSource = null;
            listaProduto.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                datePedido.Enabled = true;
            }
            else
            {
                datePedido.Enabled = false;
            }
        }

        private void cbProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            txtQuantidade.Focus();
        }
    }
}
