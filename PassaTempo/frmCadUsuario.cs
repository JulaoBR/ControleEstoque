using CONTROL;
using DAO;
using MODEL;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadUsuario : PassaTempo.frmCadastro
    {
        //VARIAVEL DE CONTROLE
        // 0 = NOVO 
        // 1 = EDITAR
        private int controle = 0;

        //MODELO
        private ModelUsuario model = new ModelUsuario();

        public frmCadUsuario()
        {
            InitializeComponent();

        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void frmCadUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle = 0;
            LimpaCampo();
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
            frmPesquisaUsuario frmUsuario = new frmPesquisaUsuario();
            ControleUsuario control = new ControleUsuario();

            frmUsuario.ShowDialog();

            if(frmUsuario.codigo != 0)
            {
                PreencheCampos(control.BuscaUsuario(frmUsuario.codigo));
            }
            else
            {
                LimpaCampo();
                
            }
        }

        private void txtNomeUsuario_Validating(object sender, CancelEventArgs e)
        {
            if(txtNomeUsuario.Text == "")
            {          
                errorProvider1.SetError(txtNomeUsuario,"Digite o nome do usuario!!");
                txtNomeUsuario.Focus();
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void cdFuncao_Validating(object sender, CancelEventArgs e)
        {
            if(cdFuncao.Text == "")
            {
                errorProvider1.SetError(cdFuncao, "Selecione a função!!");
                cdFuncao.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (txtLogin.Text == "")
            {
                errorProvider1.SetError(txtLogin, "Digite um login!!");
                txtLogin.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (txtSenha.Text == "")
            {
                errorProvider1.SetError(txtSenha, "Digite uma senha!!");
                txtSenha.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void PreencheModelo()
        {
            if(controle == 1)
            {
                model.Id_usuario = Convert.ToInt32(txtCodigoUsuario.Text);
            }
        
            model.nome_usuario = txtNomeUsuario.Text;
            model.funcao = cdFuncao.Text;
            model.login = txtLogin.Text;
            model.senha = txtSenha.Text;
        }

        private void SalvarModelo()
        {
            ControleUsuario control = new ControleUsuario();
            if (controle == 0)
            {
                control.Inserir(model);
            }
            else if (controle == 1)
            {
                control.Alterar(model);
            }

        }

        private void LimpaCampo()
        {
            txtNomeUsuario.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtCodigoUsuario.Clear();
            cdFuncao.SelectedIndex = -1;

            //==========================
            controle = 0;
        }

        private void PreencheCampos(DataTable tb)
        {
            txtCodigoUsuario.Text = tb.Rows[0]["Id_usuario"].ToString();
            txtNomeUsuario.Text = tb.Rows[0]["nome_usuario"].ToString();
            cdFuncao.Text = tb.Rows[0]["funcao"].ToString();
            txtLogin.Text = tb.Rows[0]["login"].ToString();
            txtSenha.Text = tb.Rows[0]["senha"].ToString();
        }

        private bool VerificaCampos()
        {
            if (txtNomeUsuario.Text == string.Empty || txtSenha.Text == string.Empty ||txtSenha.Text == string.Empty
                || cdFuncao.Text == string.Empty)
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
