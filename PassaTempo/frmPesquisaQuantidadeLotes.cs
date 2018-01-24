using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaQuantidadeLotes : PassaTempo.frmTelaDePesquisa
    {
        private int tipoProduto = 1;

        public frmPesquisaQuantidadeLotes()
        {
            InitializeComponent();
            gridLotes.AutoGenerateColumns = false;
        }

        private void frmPesquisaQuantidadeLotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaQuantidadeLotes_Load(sender, e);
        }

        private void frmPesquisaQuantidadeLotes_Load(object sender, EventArgs e)
        {
            QuantidadeLotes();
        }

        private void QuantidadeLotes()
        {
            List<ModelRegistro> lista = new List<ModelRegistro>();
            ControleProduto produto = new ControleProduto();
            ControleEstoqueAtual estoque = new ControleEstoqueAtual();
            ModelRegistro registro;
            var listaProduto = produto.BuscaString(txtPesquisa.Text, tipoProduto);

            foreach (DataRow item in listaProduto.Rows)
            {
                var fila = estoque.CalculaLotes(Convert.ToInt32(item["ID"].ToString()));

                foreach (var item2 in fila)
                {
                    registro = new ModelRegistro();

                    registro.Id_registro = item2.Id_lote;
                    registro.Id_produto = item2.Id_produto;                
                    registro.Dsc_produto = item["PRODUTO"].ToString();
                    registro.lote = Convert.ToString(item2.lote + " - " + item2.restante);
                    registro.data_fabricacao = item2.data_fabricacao;
                    registro.data_vencimento = item2.data_vencimento;

                    lista.Add(registro);
                }
            }

            PreencheGrid(lista);
        }

        private void PreencheGrid(List<ModelRegistro> lista)
        {
            gridLotes.DataSource = null;
            gridLotes.DataSource = lista;
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
                LimpaCampoProduto();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SaldaDados();
            LimpaCampoProduto();
            QuantidadeLotes();
        }

        private void LimpaCampoProduto()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtLote.Clear();
        }

        private void PreencheCamposProduto(DataTable tb)
        {
            txtProduto.Text = tb.Rows[0]["dsc_produto"].ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampoProduto();
        }

        private void SaldaDados()
        {
            try
            {
                ControleLotes lotes = new ControleLotes();
                ModelLotes modelo = new ModelLotes();
                List<ModelLotes> lista = new List<ModelLotes>();

                modelo.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modelo.lote = txtLote.Text;
                modelo.qtd_produto = Convert.ToDouble(txtQuantidade.Text);

                lista.Add(modelo);

                lotes.Inserir(lista);
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos!","Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    
    }
}
