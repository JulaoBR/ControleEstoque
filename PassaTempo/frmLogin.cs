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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {           
            ControleUsuario controle = new ControleUsuario();
            ModelUsuario user = new ModelUsuario();

            user.login = txtUsuario.Text;
            user.senha = txtSenha.Text;

            if (controle.VerificaUsuario(user))
            {
                frmMenu menu = new frmMenu(user);
                menu.Show();
                this.Hide();
            }
            else
            {
                LimpaCampo();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }


        private void LimpaCampo()
        {
            txtSenha.Clear();
            txtUsuario.Clear();

            txtUsuario.Focus();
        }
        //========================================
    }
}
