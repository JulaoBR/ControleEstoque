using CONTROL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadVeilculos : PassaTempo.frmCadastro
    {
        private int controle = 0;

        public frmCadVeilculos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.inicioBotoes();
            PreencheModel();
            LimpaCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            this.inicioBotoes();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmPesquisaCaminhao caminhao = new frmPesquisaCaminhao();
            ControleVeiculos control = new ControleVeiculos();

            caminhao.ShowDialog();

            if (caminhao.codigo != 0)
            {
                PreencheCampos(control.BuscaVeiculos(caminhao.codigo));
            }
            else
            {
                LimpaCampo();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void txtTara_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPesoBruto.Text = Convert.ToString(Convert.ToDouble(txtTara.Text) + Convert.ToDouble(txtLotacao.Text));
            }
            catch
            {
                txtPesoBruto.Clear();
            }
        }

        private void txtLotacao_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPesoBruto.Text = Convert.ToString(Convert.ToDouble(txtTara.Text) + Convert.ToDouble(txtLotacao.Text));
            }
            catch
            {
                txtPesoBruto.Clear();
            }
        }

        private void PreencheCampos(DataTable tb)
        {
            txtCodigoVeiculo.Text = tb.Rows[0]["ID"].ToString();
            txtNomeCaminhao.Text = tb.Rows[0]["NOME"].ToString();
            txtTara.Text = tb.Rows[0]["TARA"].ToString();
            txtLotacao.Text = tb.Rows[0]["LOTAÇÃO"].ToString();
            txtPesoBruto.Text = Convert.ToString(Convert.ToDouble(tb.Rows[0]["TARA"].ToString()) * Convert.ToDouble(tb.Rows[0]["LOTAÇÃO"].ToString()));
            txtPlaca.Text = tb.Rows[0]["PLACA"].ToString();
        }

        private void PreencheModel()
        {
            ModelVeiculos model = new ModelVeiculos();
            ControleVeiculos veiculo = new ControleVeiculos();
            try
            {
                model.dsc_veiculo = txtNomeCaminhao.Text;
                model.tara = Convert.ToDouble(txtTara.Text);
                model.lotacao = Convert.ToDouble(txtLotacao.Text);
                model.placa = txtPlaca.Text;

                if (controle == 0)
                {
                    veiculo.Inserir(model);
                }else if(controle == 1)
                {
                    veiculo.Alterar(model);
                }
                
            }
            catch
            {
                MessageBox.Show("Existem campos vazios!","Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private void LimpaCampo()
        {
            txtCodigoVeiculo.Clear();
            txtNomeCaminhao.Clear();
            txtPesoBruto.Clear();
            txtPlaca.Clear();
            txtTara.Clear();
            txtLotacao.Clear();

            controle = 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle = 1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoVeiculo.Text != string.Empty)
            {
                //Comando que questiona ao usuário se relamente deseja sair do programa
                DialogResult result = MessageBox.Show("Deseja excluir o item selecionado?",
                   "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ControleVeiculos control = new ControleVeiculos();
                    control.Excluir(Convert.ToInt32(txtCodigoVeiculo.Text));

                    LimpaCampo();
                    this.inicioBotoes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item que deseja excluir!", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
