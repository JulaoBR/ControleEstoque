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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.inicioBotoes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.inicioBotoes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        //=======================================================

        public void inicioBotoes()
        {
            btnEditar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }


    }
}
