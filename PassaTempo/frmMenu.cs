using CONTROL;
using MODEL;
using ProEstoque;
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
        private int nivel_acesso;
        private ModelConfiguracao model;

        public frmMenu(ModelUsuario usuario)
        {
            InitializeComponent();
            RodapeDoMenu(usuario);
            NivelAcesso();
            gridProduto.AutoGenerateColumns = false;

        }

        private void NivelAcesso()
        {
            if (nivel_acesso == 1)
            {
                cADASTROToolStripMenuItem.Enabled = true;
                mOVIMENTAÇÃOToolStripMenuItem.Enabled = true;
                vISUALIZAÇÃOToolStripMenuItem.Enabled = true;
                fERRAMENTASToolStripMenuItem.Enabled = true;
                cONFIGURAÇÕESToolStripMenuItem.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

            }else if (nivel_acesso == 2)
            {
                cADASTROToolStripMenuItem.Enabled = false;
                mOVIMENTAÇÃOToolStripMenuItem.Enabled = true;
                vISUALIZAÇÃOToolStripMenuItem.Enabled = true;
                fERRAMENTASToolStripMenuItem.Enabled = true;
                cONFIGURAÇÕESToolStripMenuItem.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

            }else if (nivel_acesso == 3)
            {
                cADASTROToolStripMenuItem.Enabled = false;
                mOVIMENTAÇÃOToolStripMenuItem.Enabled = false;
                vISUALIZAÇÃOToolStripMenuItem.Enabled = true;
                fERRAMENTASToolStripMenuItem.Enabled = true;
                cONFIGURAÇÕESToolStripMenuItem.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;

            }
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
            frmCarga frmCarga = new frmCarga(userLogado);
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
                ControleUsuario.RegistroAtividade(userLogado, "terminou a sessão");  
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
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja realmente encerrar a aplicação?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            model = ControleConfiguracao.BuscaValor();

            //CONFIGURACAO DOS BOTOES
            if (model.controle_botoes_menu != 1)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }

            //CONFIGURACAO DO GRID DE PRODUTO
            if (model.lista_produto_menu != 1)
            {
                gridProduto.Visible = false;
            }
            else
            {
                var lista = ControleEstoqueAtual.BuscaDados(model.item_lista_produto_menu, "");
                PreencheGrid(lista);
                gridProduto.Visible = true;
            }
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
            nivel_acesso = Convert.ToInt32(dados.Rows[0]["nivel"].ToString());
            stripFuncao.Text = dados.Rows[0]["funcao"].ToString();
            stripUsuario.Text = userLogado ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMenu_Load(sender, e);
        }

        private void mATERIAPRIMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateriaPrima prima = new frmMateriaPrima();
            prima.ShowDialog();
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPedidosMateriaPrima materia = new frmCadPedidosMateriaPrima(userLogado);
            materia.ShowDialog();
        }

        private void pEDIDOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesquisaPedidos pedidos = new frmPesquisaPedidos();
            pedidos.ShowDialog();
        }
    }
}
