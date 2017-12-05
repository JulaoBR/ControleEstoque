using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCalculaPesoCarga : Form
    {
        private List<ModelRegistro> lista = new List<ModelRegistro>();
        private double totalCaixas = 0;
        private double totalCarga = 0;
        private double pesoTotal = 0;
                
        public frmCalculaPesoCarga()
        {
            InitializeComponent();
            gridProdutos.AutoGenerateColumns = false;
            txtCodigoProduto.Focus();          
        }

        private void frmCalculaPesoCarga_Load(object sender, EventArgs e)
        {
            CarregaComboEstado();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmproduto = new frmPesquisaProduto();           
            frmproduto.ShowDialog();
            
            if (frmproduto.codigo != 0)
            {
                ControleProduto produto = new ControleProduto();

                var dt = produto.BuscaInt(frmproduto.codigo);
                txtCodigoProduto.Text = dt.Rows[0]["Id_produto"].ToString();
                txtNomeProduto.Text = dt.Rows[0]["dsc_produto"].ToString();
                txtLiquido.Text = dt.Rows[0]["peso_liquido"].ToString();
                txtPesoBruto.Text = dt.Rows[0]["peso_bruto"].ToString();

                txtQuantidade.Focus();
            }
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

        private void gridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codigo = Convert.ToInt32(gridProdutos.Rows[e.RowIndex].Cells[0].Value);

                //PERGUNTA SE DESEJA EXCLUIR UM ITEM DA LISTA
                DialogResult d = MessageBox.Show("Deseja remover este ITEM?", "AVISO!!", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    RemoverItemListaRegistro(codigo);
                }
                else
                {
                    return;
                }
            }
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(cbNomeCaminhao.Text != string.Empty)
            {
                AddCargasCaminhao();
                PreencheCaminhao();

                lbPesoBruto.Text = "0";
                lbTotalCaixa.Text = "0";
                lbTotalItens.Text = "0";
                lbPesoLiquido.Text = "0";
                lista.Clear();
                PreencheGrid();

                verificaPeso();

                txtCodigoProduto.Focus();
            }
            else
            {
                
                MessageBox.Show("Selecione um caminhão/produto para continuar a operação...", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
                     
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AdicionaLista();
            PreencheGrid();
            AtualizaInfo();
            LimpaCampoProduto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCaminhao();
            panelCaminhao.BackColor = System.Drawing.Color.White;
            LimpaCampoCaminhao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            LimpaCampoProduto();

            lbPesoBruto.Text = "0";
            lbTotalCaixa.Text = "0";
            lbTotalItens.Text = "0";
            lbPesoLiquido.Text = "0";

            PreencheGrid();         
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
            lbPesoLiquido.Text = Convert.ToString(string.Format("{0:N}", aux1));
            lbPesoBruto.Text = Convert.ToString(string.Format("{0:N}", aux2));
        }

        private void txtCodigoProduto_Leave(object sender, EventArgs e)
        {
            BuscaDados();
        }

        private void BuscaDados()
        {
            ControleProduto produto = new ControleProduto();

            try
            {
                var dt = produto.BuscaInt(Convert.ToInt32(txtCodigoProduto.Text));

                txtNomeProduto.Text = dt.Rows[0]["dsc_produto"].ToString();
                txtLiquido.Text = dt.Rows[0]["peso_liquido"].ToString();
                txtPesoBruto.Text = dt.Rows[0]["peso_bruto"].ToString();
            }
            catch
            {

            }          
        }

        private void AdicionaLista()
        {
            ModelRegistro model = new ModelRegistro();
            try
            {
                model.Id_produto = Convert.ToInt32(txtCodigoProduto.Text);
                model.Dsc_produto = txtNomeProduto.Text;
                model.qtd_produto = Convert.ToDouble(txtQuantidade.Text);
                model.pesoBruto = Convert.ToDouble(string.Format("{0:N}", Convert.ToDouble(txtPesoBruto.Text) * Convert.ToDouble(txtQuantidade.Text)));
                model.pesoLiquido = Convert.ToDouble(string.Format("{0:N}", (Convert.ToDouble(txtLiquido.Text) * Convert.ToDouble(txtQuantidade.Text))));

                lista.Add(model);
            }
            catch
            {
                MessageBox.Show("Existe campos obrigatórios vazios!","Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }


        private void LimpaCampoProduto()
        {
            txtCodigoProduto.Clear();
            txtNomeProduto.Clear();
            txtPesoBruto.Clear();
            txtLiquido.Clear();
            txtQuantidade.Clear();

            txtCodigoProduto.Focus();
        }

        private void LimpaCaminhao()
        {
            txtLotacao.Clear();
            txtTara.Clear();
            txtPesoBrutoTotal.Clear();
            txtPlaca.Clear();
            txtTolerancia.Clear();
        }


        //METODO PARA REMOVER ITENS DA LISTA
        private void RemoverItemListaRegistro(int codigo)
        {
            foreach (var item in lista)
            {
                if (codigo == item.Id_produto)
                {
                    //REMOVE O PRODUTO SELECIONADO
                    lista.Remove(item);
                    //ATUALIZA O GRID COM A LISTA SEM O VALOR RETIRADO
                    PreencheGrid();
                    AtualizaInfo();
                    return;
                }
            }
        }

        private void AddCargasCaminhao()
        {
            totalCaixas += Convert.ToDouble(lbTotalCaixa.Text);
            ++ totalCarga ;
            pesoTotal += Convert.ToDouble(lbPesoBruto.Text);
        }

        private void PreencheCaminhao()
        {
            txtPesoTotal.Text = Convert.ToString(pesoTotal);
            txtTotalCaixas.Text = Convert.ToString(totalCaixas);
            txtTotalCargas.Text = Convert.ToString(totalCarga);
        }

        private void LimpaCampoCaminhao()
        {
            txtPesoTotal.Clear();
            txtTotalCaixas.Clear();
            txtTotalCargas.Clear();

            totalCaixas = 0;
            totalCarga = 0;
            pesoTotal = 0;
        }

        private void CarregaComboEstado()
        {
            ControleVeiculos control = new ControleVeiculos();

            cbNomeCaminhao.DataSource = control.BuscaVeiculos("");
            cbNomeCaminhao.DisplayMember = "NOME";
            cbNomeCaminhao.ValueMember = "ID";
            cbNomeCaminhao.SelectedIndex = -1;          
        }


        private void PreencheCampos()
        {
            ControleVeiculos control = new ControleVeiculos();
            if (cbNomeCaminhao.ValueMember != string.Empty)
            {
                DataTable tb = control.BuscaVeiculos(Convert.ToInt32(cbNomeCaminhao.SelectedValue));

                txtTara.Text = tb.Rows[0]["TARA"].ToString();
                txtLotacao.Text = tb.Rows[0]["LOTAÇÃO"].ToString();
                txtPesoBrutoTotal.Text = Convert.ToString(Convert.ToDouble(tb.Rows[0]["TARA"].ToString()) + Convert.ToDouble(tb.Rows[0]["LOTAÇÃO"].ToString()));
                txtPlaca.Text = tb.Rows[0]["PLACA"].ToString();
            }
            
        }

        private void cbNomeCaminhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaCaminhao();            
            PreencheCampos();
        }

        private void verificaPeso()
        {
            try
            {
                if (Convert.ToDouble(txtPesoBrutoTotal.Text) < Convert.ToDouble(txtPesoTotal.Text))
                {
                    panelCaminhao.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    panelCaminhao.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Selecione um caminhão para continuar a operação...","Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
