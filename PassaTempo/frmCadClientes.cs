using CONTROL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCadClientes : PassaTempo.frmCadastro
    {
        //VARIAVEL DE CONTROLE
        // 0 = NOVO 
        // 1 = EDITAR
        private int controle = 0;
        public int codigo = 0;

        //MODELO
        private ModelCliente cliente = new ModelCliente();

        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            CarregaComboEstado();
        }

        private void frmCadClientes_KeyDown(object sender, KeyEventArgs e)
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
                codigo = Convert.ToInt32(txtCodCliente.Text);
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
            frmPesquisaCliente frmCliente = new frmPesquisaCliente();
            ControleCliente control = new ControleCliente();
            frmCliente.ShowDialog();
            if (frmCliente.codigo != 0)
            {
                PreencheCampos(control.BuscaInt(frmCliente.codigo));
            }
            else
            {
                LimpaCampo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaComboCidade();
        }

        private void txtCodCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCodCliente.Text == "")
            {
                errorProvider1.SetError(txtCodCliente, "Digite o codigo do cliente!!");
                txtCodCliente.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNomeCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                errorProvider1.SetError(txtNomeCliente, "Digite o nome do cliente!!");
                txtNomeCliente.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEndereco_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                errorProvider1.SetError(txtEndereco, "Digite o endereço do cliente!!");
                txtEndereco.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbEstado_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbEstado.Text == "")
            {
                errorProvider1.SetError(cbEstado, "Selecione o estado!!");
                cbEstado.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbCidade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbCidade.Text == "")
            {
                errorProvider1.SetError(cbCidade, "Selecione a cidade!!");
                cbCidade.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void CarregaComboCidade()
        {           
            ControleCidadeEstado control = new ControleCidadeEstado();

            if (cbEstado.SelectedValue != null && cbEstado.ValueMember != "")
            {
                cbCidade.DataSource = control.BuscaCidadeEstado(Convert.ToInt32(cbEstado.SelectedValue));
                cbCidade.DisplayMember = "nome_cidade";
                cbCidade.ValueMember = "Id_cidade";
            }
        }

        private void CarregaComboEstado()
        {
            ControleCidadeEstado control = new ControleCidadeEstado();

            cbEstado.DataSource = control.BuscaEstado("");
            cbEstado.DisplayMember = "nome_estado";
            cbEstado.ValueMember = "Id_estado";
            cbEstado.SelectedIndex = -1;

        }

        private void LimpaCampo()
        {
            txtNomeCliente.Clear();
            txtEndereco.Clear();
            txtCodCliente.Clear();
            cbCidade.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            txtCodCliente.Focus();

            //===========================
            controle = 0;
        }

        private void PreencheModelo()
        {          
            cliente.Id_cliente = Convert.ToInt32(txtCodCliente.Text);
            cliente.Id_estado = Convert.ToInt32(cbEstado.SelectedValue);
            cliente.Id_cidade = Convert.ToInt32(cbCidade.SelectedValue);
            cliente.nome_cliente = txtNomeCliente.Text;
            cliente.endereco = txtEndereco.Text;           
        }

        private void SalvarModelo()
        {
            ControleCliente control = new ControleCliente();
            if (controle == 0)
            {
                control.Inserir(cliente);
            }
            else if (controle == 1)
            {
                control.Alterar(cliente);
            }

        }

        private void PreencheCampos(DataTable tb)
        {
            txtCodCliente.Text = tb.Rows[0]["Id_cliente"].ToString();
            cbCidade.Text = tb.Rows[0]["nome_cidade"].ToString();
            cbEstado.Text = tb.Rows[0]["nome_estado"].ToString();
            txtNomeCliente.Text = tb.Rows[0]["nome_cliente"].ToString();
            txtEndereco.Text = tb.Rows[0]["endereco"].ToString();
        }

        private bool VerificaCampos()
        {
            if (txtNomeCliente.Text == string.Empty || txtEndereco.Text == string.Empty || cbEstado.Text == string.Empty || cbCidade.Text == string.Empty)
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
