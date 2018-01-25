using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPrimeiroAcesso : Form
    {
        private int Id_usuario;
        public frmPrimeiroAcesso(int Id_usuario)
        {
            InitializeComponent();
            this.Id_usuario = Id_usuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModelUsuario modelo = new ModelUsuario();
            ControleUsuario controle = new ControleUsuario();

            modelo.Id_usuario = Id_usuario;
            modelo.login = txtLogin.Text;
            if (ValidadorSenha())
            {
                modelo.senha = txtSenha.Text;
                modelo.controle = 1;
                controle.AlterarAtualizacaoSenha(modelo);
                frmMenu menu = new frmMenu(modelo);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique a senha digitada!","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidadorSenha()
        {
            var senha = txtSenha.Text;
            var confirmacao = txtConfirmacaoSenha.Text;

            if (senha.Equals(confirmacao))
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
