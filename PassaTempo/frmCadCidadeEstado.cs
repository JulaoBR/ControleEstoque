using CONTROL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadCidadeEstado : PassaTempo.frmCadastro
    {
        //VARIAVEL DE CONTROLE
        // 0 = NOVO 
        // 1 = EDITAR
        private int controle = 0;

        //MODELO
        private ModelEstadoCidade model = new ModelEstadoCidade();

        public frmCadCidadeEstado()
        {
            InitializeComponent();          
        }

        private void frmCadCidadeEstado_Load(object sender, EventArgs e)
        {
            rbCidade.Checked = true;
            CarregaComboEstado();
        }

        private void rbCidade_CheckedChanged(object sender, EventArgs e)
        {
            txtNomeCidade.Enabled = true;
            txtCep.Enabled = true;
            cbEstado.Enabled = true;
            //===============================
            txtNomeEstado.Enabled = false;
        }

        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {

            txtNomeEstado.Enabled = true;
            //================================
            txtNomeCidade.Enabled = false;
            txtCep.Enabled = false;
            cbEstado.Enabled = false;
        }

        private void frmCadCidadeEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
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
            if (VerificaCampo())
            {
                PreencheModelo();
                LimpaCampo();
                this.inicioBotoes();
                SalvaModelo();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatorios para realizar esta operação!!", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {                   
            ControleCidadeEstado control = new ControleCidadeEstado();           

            if (rbCidade.Checked)
            {
                frmPesquisaCidade frmCidade = new frmPesquisaCidade();
                frmCidade.ShowDialog();
                if (frmCidade.codigo != 0)
                {
                    PreencheCampo(control.BuscaCidade(frmCidade.codigo));
                }
                else
                {
                    LimpaCampo();
                }
            }else if (rbEstado.Checked)
            {
                frmPesquisaEstado frmEstado = new frmPesquisaEstado();
                frmEstado.ShowDialog();
                if(frmEstado.codigo != 0)
                {
                    PreencheCampo(control.BuscaEstado(frmEstado.codigo));
                }
                else
                {
                    LimpaCampo();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            controle = 0;
            model = null;
        }

        private void SalvaModelo()
        {
            ControleCidadeEstado control = new ControleCidadeEstado();
            if (controle == 0)
            {
                if (rbEstado.Checked)
                {
                    control.InserirEstado(model);
                    txtNomeEstado.Focus();
                }
                else if (rbCidade.Checked)
                {
                    control.InserirCidade(model);
                    txtNomeCidade.Focus();
                }
            }
            else if (controle == 1)
            {
                if (rbEstado.Checked)
                {
                    control.AlterarEstado(model);
                }
                else if (rbCidade.Checked)
                {
                    control.AlterarCidade(model);
                }
            }
        }

        private void PreencheModelo()
        {
            if(controle == 1)
            {
                if (rbCidade.Checked)
                {
                    model.Id_cidade = Convert.ToInt32(txtCodigoCidade.Text);
                }else if (rbEstado.Checked)
                {
                    model.Id_estado = Convert.ToInt32(txtCodEstado.Text);
                }
            }

            if (rbCidade.Checked)
            {
                model.nome_cidade = txtNomeCidade.Text;
                model.Id_estado = Convert.ToInt32(cbEstado.SelectedValue);
                model.cep = txtCep.Text;
            }else if (rbEstado.Checked)
            {
                model.nome_estado = txtNomeEstado.Text;
            }
        }

        private void LimpaCampo()
        {
            txtNomeCidade.Clear();
            txtCodigoCidade.Clear();
            txtCodEstado.Clear();
            txtNomeEstado.Clear();
            txtCep.Clear();
            cbEstado.SelectedIndex = -1;
            //========================
            controle = 0;
        }

        private void PreencheCampo(DataTable tb)
        {
            if (rbCidade.Checked)
            {
                txtCodigoCidade.Text = tb.Rows[0]["Id_cidade"].ToString();
                txtNomeCidade.Text = tb.Rows[0]["nome_cidade"].ToString();
                //cbEstado.Text =
                txtCep.Text = tb.Rows[0]["cep"].ToString();
            }else if (rbEstado.Checked)
            {
                txtCodEstado.Text = tb.Rows[0]["Id_estado"].ToString();
                txtNomeEstado.Text = tb.Rows[0]["nome_estado"].ToString();
            }
        }

        private bool VerificaCampo()
        {
            if (rbCidade.Checked)
            {
                if (txtNomeCidade.Text == string.Empty || txtCep.Text == string.Empty || cbEstado.Text == string.Empty)
                {
                    return false;
                }
            }else if (rbEstado.Checked)
            {
                if(txtNomeEstado.Text == string.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        private void CarregaComboEstado()
        {
           ControleCidadeEstado control = new ControleCidadeEstado();

            cbEstado.DataSource = control.BuscaEstado("");
            cbEstado.DisplayMember = "nome_estado";
            cbEstado.ValueMember = "Id_estado";
            cbEstado.SelectedIndex = -1;

        }
    }
}
