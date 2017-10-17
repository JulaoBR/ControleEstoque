using CONTROL;
using MODEL;
using System;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadVeilculos : PassaTempo.frmCadastro
    {
        public frmCadVeilculos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PreencheModel();
            LimpaCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmPesquisaCaminhao caminhao = new frmPesquisaCaminhao();
            caminhao.ShowDialog();
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

                veiculo.Inserir(model);
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
        }


    }
}
