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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
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


    }
}
