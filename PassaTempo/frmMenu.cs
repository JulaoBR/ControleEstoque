using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmMenu : Form
    {
        private string userLogado;

        public frmMenu(ModelUsuario usuario)
        {
            InitializeComponent();
            RodapeDoMenu(usuario);
            gridProduto.AutoGenerateColumns = false;
        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new frmCadProdutos();
            frmCadProdutos.ShowDialog();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClientes frmCadCliente = new frmCadClientes();
            frmCadCliente.ShowDialog();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUsuario frmCadUsuario = new frmCadUsuario();
            frmCadUsuario.ShowDialog();
        }

        private void cARGASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarga frmCarga = new frmCarga();
            frmCarga.ShowDialog();
        }

        private void eNTRADASAIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmMovimentacao = new frmMovimentacao();
            frmMovimentacao.ShowDialog();
        }

        private void cALCULADORADEDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora frmCalculadora = new frmCalculadora();
            frmCalculadora.ShowDialog();
        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaEstoque frmEstoque = new frmPesquisaEstoque();
            frmEstoque.ShowDialog();
        }

        private void sAIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaSaida frmSaidas = new frmPesquisaSaida(2);
            frmSaidas.ShowDialog();
        }

        private void eNTRADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaEntrada frmEntrada = new frmPesquisaEntrada();
            frmEntrada.ShowDialog();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja realmente encerrar a aplicação?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void sAIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja realmente encerrar a aplicação?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
           {        
                Application.Exit();
            }
        }

        private void rASTREAMENTODELOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRastreioDeLotes frmRastreamento = new frmRastreioDeLotes();
            frmRastreamento.ShowDialog();
        }

        private void cIDADEESTADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCidadeEstado frmCidadeEstado = new frmCadCidadeEstado();
            frmCidadeEstado.ShowDialog();
        }

        private void rOTASDEENTREGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRotasEntregas frmRotas = new frmRotasEntregas();
            frmRotas.ShowDialog();
            
        }

        private void cALCULAPESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculaPesoCarga frmCalcula = new frmCalculaPesoCarga();
            frmCalcula.ShowDialog();
        }

        private void vEICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadVeilculos frmVeiculos = new frmCadVeilculos();
            frmVeiculos.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMenu_Load( sender, e);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var lista = ControleEstoqueAtual.BuscaDados(1, "");
            PreencheGrid(lista);
        }

        //==========================================================================


        private void PreencheGrid(List<ModelProduto> lista)
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = lista;
            gridProduto.ClearSelection();
            ColorirCelulaEstoque(lista);
        }

        //METODO PARA COLORIR AS LINHAS DO GRID ESTOQUE
        private void ColorirCelulaEstoque(List<ModelProduto> Lista)
        {
            int cont = 0;
            int i = 0;
            foreach (var item in Lista)
            {
                if (item.qtd_estoque < item.qtd_minimo)
                {
                    DataGridViewRow row = gridProduto.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Red;
                    cont++;
                }

                i++;
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaConfiguracao config = new frmTelaConfiguracao();
            config.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cALCULADORADEDATAToolStripMenuItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cARGASToolStripMenuItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eNTRADASAIDAToolStripMenuItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rASTREAMENTODELOTEToolStripMenuItem_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cALCULAPESOToolStripMenuItem_Click(sender, e);
        }

        private void tOTALENTRADASAIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaTotal frmTotal = new frmPesquisaTotal();
            frmTotal.ShowDialog();
        }

        private void qUANTIDADEDECADALOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaQuantidadeLotes qtdLotes = new frmPesquisaQuantidadeLotes();
            qtdLotes.ShowDialog();
        }

        //METODO PARA PREENCHER O NOME DO FUNCIONARIO LOGADO
        private void RodapeDoMenu(ModelUsuario user)
        {
            ControleUsuario controle = new ControleUsuario();
            DataTable dados = controle.BuscaUsuarioLogado(user);

            userLogado = dados.Rows[0]["nome_usuario"].ToString();

            stripUsuario.Text = userLogado ;
        }


    }
}
