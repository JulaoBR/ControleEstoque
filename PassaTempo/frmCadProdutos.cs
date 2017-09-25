using CONTROL;
using MODEL;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadProdutos : PassaTempo.frmCadastro
    {
        //VARIAVEL DE CONTROLE
        // 0 = NOVO 
        // 1 = EDITAR
        private int controle = 0;

        //MODELO
        private ModelProduto model = new ModelProduto();

        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {

        }

        private void frmCadProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                PreencheModelo();
                LimpaCampo();
                this.inicioBotoes();
                SalvarModelo();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatorios para realizar esta operação!!", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja excluir o item selecionado?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmProduto = new frmPesquisaProduto();
            ControleProduto control = new ControleProduto();
            frmProduto.ShowDialog();

            if(frmProduto.codigo != 0)
            {
                PreencheCampos(control.BuscaInt(frmProduto.codigo));
            }
            else
            {
                LimpaCampo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void txtNomeProduto_Validating(object sender, CancelEventArgs e)
        {
            if (txtNomeProduto.Text == "")
            {
                errorProvider1.SetError(txtNomeProduto, "Digite o nome do produto!!");
                txtNomeProduto.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbUnidadeMedida_Validating(object sender, CancelEventArgs e)
        {
            if (cbUnidadeMedida.Text == "")
            {
                errorProvider1.SetError(cbUnidadeMedida, "Selecione a unidade de medida!!");
                cbUnidadeMedida.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPrazoValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPesoLiquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.Formatacao(ref txtPesoLiquido);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {            
                e.Handled = true;
            }           
        }
      
        private void txtPesoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.Formatacao(ref txtPesoBruto);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cbTipoProduto_Validating(object sender, CancelEventArgs e)
        {
            if (cbTipoProduto.Text == "")
            {
                errorProvider1.SetError(cbTipoProduto, "Selecione o tipo de produto!!");
                cbTipoProduto.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void LimpaCampo()
        {
            txtCodigoProduto.Clear();
            txtNomeProduto.Clear();
            cbUnidadeMedida.SelectedIndex = -1;
            cbTipoProduto.SelectedIndex = -1;
            txtPrazoValidade.Clear();
            txtPesoBruto.Clear();
            txtPesoLiquido.Clear();
            txtEstoqueMaximo.Clear();
            txtEstoqueMinimo.Clear();
            txtNomeProduto.Focus();

            //===========================

            controle = 0;
        }

        private void PreencheModelo()
        {
            if (controle == 1)      //VERIFICA SE É UM NOVO PRODUTO OU UM EDITAR
            {
                model.Id_produto = Convert.ToInt32(txtCodigoProduto.Text);
            }

            model.DscProduto = txtNomeProduto.Text;
            model.unidade_medida = cbUnidadeMedida.Text;

            if (cbTipoProduto.Equals("MP"))     //VERIFICA SE È MATERIA PRIMA OU PRODUTO FINAL
            {
                model.tipo_produto = 0;
            }
            else
            {
                model.tipo_produto = 1;
            }

            model.prazo_validade = Convert.ToInt32(txtPrazoValidade.Text);
            model.qtd_minimo = Convert.ToDouble(txtEstoqueMinimo.Text);
            model.qtd_maximo = Convert.ToDouble(txtEstoqueMaximo.Text);
            model.peso_bruto = Convert.ToDouble(txtPesoBruto.Text);
            model.peso_liquido = Convert.ToDouble(txtPesoLiquido.Text);

            
        }

        private void SalvarModelo()
        {
            ControleProduto control = new ControleProduto();
            if (controle == 0)
            {
                control.Inserir(model);
            }
            else if (controle == 1)
            {
                control.Alterar(model);
            }

        }

        private void PreencheCampos(DataTable tb)
        {
            txtCodigoProduto.Text = tb.Rows[0]["Id_produto"].ToString();
            txtNomeProduto.Text = tb.Rows[0]["dsc_produto"].ToString();
            cbUnidadeMedida.Text = tb.Rows[0]["unidade_medida"].ToString();
            int var = Convert.ToInt32(tb.Rows[0]["tipo_produto"].ToString());
            if ( var == 0)
            {
                cbTipoProduto.Text = "MP";
            }
            else
            {
                cbTipoProduto.Text = "PF";
            }
            txtPrazoValidade.Text = tb.Rows[0]["prazo_validade"].ToString();
            txtPesoLiquido.Text = tb.Rows[0]["peso_liquido"].ToString();
            txtPesoBruto.Text = tb.Rows[0]["peso_bruto"].ToString();
            txtEstoqueMinimo.Text = tb.Rows[0]["qtd_minimo"].ToString();
            txtEstoqueMaximo.Text = tb.Rows[0]["qtd_maximo"].ToString();
            
        }

        private bool VerificaCampos()
        {
            if (txtNomeProduto.Text == string.Empty || cbUnidadeMedida.Text == string.Empty || cbTipoProduto.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
