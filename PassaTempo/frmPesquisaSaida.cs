using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaSaida : PassaTempo.frmTelaDePesquisa
    {
        private int opcao = 0; //1 = nome , 2 = codigo carga, 3 = data carregamento
        private int seletor = 1;

        public frmPesquisaSaida(int opcao)
        {
            InitializeComponent();
            this.opcao = opcao;
        }

        private void frmPesquisaSaida_Load(object sender, EventArgs e)
        {
            ControleCarga carga = new ControleCarga();

            if (txtCampoData.Text == string.Empty)
            {
                PreencheGrid(carga.BuscaCarga(seletor, txtPesquisa.Text, txtCampoData.Text));
            }
            else
            {
                PreencheGrid(carga.BuscaCarga(seletor, txtPesquisa.Text, Convert.ToDateTime(txtCampoData.Text).ToString("yyyy-MM-dd 00:00:00")));
            }
                   
            
            gridSaidaCarga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaSaida_Load(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 1;
            txtCampoData.ReadOnly = false;
            txtPesquisa.ReadOnly = false;
            LimpaCampo();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 2;
            txtCampoData.ReadOnly = true;
            txtPesquisa.ReadOnly = false;
            LimpaCampo();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCampoData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCampoData_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtCampoData);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void LimpaGrid()
        {
            gridSaidaCarga.DataSource = null;
            gridSaidaCarga.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridSaidaCarga.DataSource = tb;
        }

        private void gridSaidaCarga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(gridSaidaCarga.Rows[e.RowIndex].Cells[0].Value);

                    if (opcao == 1) // SE IGUAL A EXCLUI CARGA
                    {
                        ExcluirCarga(codigo);

                    }
                    else if (opcao == 2) // ABRE TELA DE CARGA DETALHADA
                    {
                        frmCargaDetalhada frmDetalhada = new frmCargaDetalhada(codigo);
                        frmDetalhada.ShowDialog();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma linha valida!","Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void ExcluirCarga(int codigo)
        {
            //PERGUNTA SE DESEJA CADASTRAR UM NOVO CLIENTE
            DialogResult d = MessageBox.Show("Deseja remover este ITEM?", "AVISO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d.ToString() == "Yes")
            {
                ControleRegistro registro = new ControleRegistro();
                ControleLotes lotes = new ControleLotes();
                ControleCarga carga = new ControleCarga();

                registro.Excluir(codigo);
                lotes.Excluir(codigo);
                carga.Excluir(codigo);

                MessageBox.Show("Carga excluida com sucesso!", "Carga Excluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void LimpaCampo()
        {
            txtCampoData.Clear();
            txtPesquisa.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }
    }
}
