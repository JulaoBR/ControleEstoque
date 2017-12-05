using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmMovimentacao : Form
    {
        //1 = proudto final
        //0 = materia prima
        private int opcao = 1;
        private int editar = 0; //CODIGO PARA SABER SE VAI SALVAR UM NOVO OU EDITAR
        private int codigo = 0; // CODIGO DO PRODUTO QUE SERA ALTERADO
        private int prazoValidade = 0;
        private ModelRegistro modelo;
        private int tipoProduto;

        public frmMovimentacao()
        {
            InitializeComponent();
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {         
            inicioBotoes();
        }

        private void rbProdutoFinal_CheckedChanged(object sender, EventArgs e)
        {
            opcao = 1;
        }

        private void rbMateriaPrima_CheckedChanged(object sender, EventArgs e)
        {
            opcao = 0;
        }

        private void rbSaida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAjuste_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisa = new frmPesquisaProduto(opcao);
            ControleProduto control = new ControleProduto();
            frmPesquisa.ShowDialog();

            if (frmPesquisa.codigo != 0)
            {
                PreencheCamposProduto(control.BuscaInt(frmPesquisa.codigo));
                txtQuantidade.Focus();
            }
            else
            {
                LimpaCampoProduto();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            editar = 1;
            ControleRegistro control = new ControleRegistro();
            frmPesquisaEntrada frmPesquisa = new frmPesquisaEntrada();
            frmPesquisa.ShowDialog();

            if (frmPesquisa.codigo != 0)
            {
                PreencheCampos(control.BuscaInt(frmPesquisa.codigo));               
                
            }
            else
            {
                LimpaCampoProduto();
                editar = 0;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(VerificaRadioButom())
            {
                PreencheModelo();
                SalvaRegistro();
                rbSaida.Checked = false;
                rbEntrada.Checked = false;

                editar = 0;
                codigo = 0;
            }
            else
            {
                MessageBox.Show("Selecione o tipo de movimentação que deseja realizar!","Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicioBotoes();
            LimpaCampoProduto();
        }

        private void frmMovimentacao_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtDataFabricacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtDataFabricacao);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                ControleProduto produto = new ControleProduto();
                ControleEstoqueAtual controle = new ControleEstoqueAtual();

                if (produto.VerificaProduto(Convert.ToInt32(txtCodProduto.Text)) == null)
                {
                    MessageBox.Show("O produto nao esta cadastrado", "Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaCampoProduto();
                    txtCodProduto.Clear();
                    txtCodProduto.Focus();
                }
                else
                {
                    PreencheCamposProduto(produto.BuscaInt(Convert.ToInt32(txtCodProduto.Text)));
                }

            }
            catch
            {
                return;
            }
        }

        private void txtDataFabricacao_Leave(object sender, EventArgs e)
        {
            try
            {             
                DateTime data = Convert.ToDateTime(txtDataFabricacao.Text);
                txtDataVencimento.Text = data.AddDays(prazoValidade).ToString("dd/MM/yyyy");              
            }
            catch
            {
                txtDataVencimento.Clear();
                return;
            }
        }
        //=========================================================

        private void inicioBotoes()
        {
            rbProdutoFinal.Checked = true;
            btnExcluir.Enabled = false;
            rbAjuste.Checked = false;
            rbEntrada.Checked = false;
            rbSaida.Checked = false;
            editar = 0;
        }

        private void PreencheCamposProduto(DataTable tb)
        {
            txtCodProduto.Text = tb.Rows[0]["Id_produto"].ToString();
            txtNomeProduto.Text = tb.Rows[0]["dsc_produto"].ToString();
            txtQuatidadeAtual.Text = Convert.ToString(ControleEstoqueAtual.CalculaEstoque(Convert.ToInt32(txtCodProduto.Text)));
            prazoValidade = Convert.ToInt32(tb.Rows[0]["prazo_validade"].ToString()); 
            tipoProduto = Convert.ToInt32(tb.Rows[0]["tipo_produto"].ToString());
        }

        private void LimpaCampoProduto()
        {
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuatidadeAtual.Clear();
            txtDataVencimento.Clear();
            txtDataFabricacao.Clear();
            txtLote.Clear();
            txtQuantidade.Clear();
            txtObservacao.Clear();
            txtCodProduto.Focus();
        }

        private void PreencheModelo()
        {
            if (!VerificaCampos())
            {
                modelo = new ModelRegistro();

                modelo.Id_produto = Convert.ToInt32(txtCodProduto.Text);
                modelo.lote = txtLote.Text;
                modelo.qtd_produto = Convert.ToDouble(txtQuantidade.Text);
                modelo.data_fabricacao = txtDataFabricacao.Text;
                modelo.data_vencimento = txtDataVencimento.Text;
                modelo.data_operacao = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd 00:00:00");
                modelo.tipo_produto = tipoProduto;
                modelo.marcacao = 0;
                modelo.observacao = txtObservacao.Text;

                if(editar == 1)
                {
                    modelo.Id_registro = codigo;
                }
                else
                {
                    modelo.Id_registro = 0;
                }


                LimpaCampoProduto();
            }
            else
            {
                MessageBox.Show("Preencha os todos os campos!","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpaCampoProduto();
            }
            
        }

        //VERIFICA OS CAMPOS PARA PREENCHER O MODELO DO REGISTRO
        private bool VerificaCampos()
        {
            if(txtCodProduto.Text == string.Empty || txtQuantidade.Text == string.Empty)
            {
                return true;
            }

            return false;               
        }

        private bool VerificaRadioButom()
        {
            if(rbEntrada.Checked || rbSaida.Checked)
            {
                return true;
            }
            return false;
        }

        private void SalvaRegistro()
        {
            ControleRegistro controle = new ControleRegistro();
            List<ModelRegistro> lista = new List<ModelRegistro>();
            try
            {
                if (rbEntrada.Checked)
                {
                    modelo.tipo_operacao = 0;
                }
                else if (rbSaida.Checked)
                {
                    modelo.tipo_operacao = 1;
                }

                if (rbAjuste.Checked)
                    modelo.ajuste = 1;
              
                lista.Add(modelo);
                if(editar == 0)
                {
                    controle.Inserir(lista);
                }else if (editar == 1)
                {
                    controle.Atualizar(lista);
                }
                    
            }
            catch
            {
                return;
            }
            
        }

        private void PreencheCampos(DataTable tb)
        {
            codigo = Convert.ToInt32(tb.Rows[0]["ID REGIS"].ToString()); //CODIGO DA CHAVE PRIMARIA PARA ALTERAR O PRODUTO
            txtCodProduto.Text = tb.Rows[0]["ID PRO"].ToString();
            txtNomeProduto.Text = tb.Rows[0]["PRODUTO"].ToString();
            txtQuantidade.Text = tb.Rows[0]["QUANTIDADE"].ToString();
            txtLote.Text = tb.Rows[0]["LOTE"].ToString();
            txtDataFabricacao.Text = tb.Rows[0]["FABRICAÇÃO"].ToString();
            txtDataVencimento.Text = tb.Rows[0]["VENCIMENTO"].ToString();
            txtObservacao.Text = tb.Rows[0]["OBSERVAÇÃO"].ToString();
            dateTimePicker1.Text = tb.Rows[0]["OPERAÇÃO"].ToString();

            tipoProduto = Convert.ToInt32(tb.Rows[0]["tipo_produto"].ToString());

            if (Convert.ToInt32(tb.Rows[0]["TIPO.OPER"].ToString()) == 0)
            {
                rbEntrada.Checked = true;
            }else if (Convert.ToInt32(tb.Rows[0]["TIPO.OPER"].ToString()) == 1)
            {
                rbSaida.Checked = true;
            }

            if (Convert.ToInt32(tb.Rows[0]["AJUSTE"].ToString()) != 0){
                rbAjuste.Checked = true;
            }

        }
    }
}
