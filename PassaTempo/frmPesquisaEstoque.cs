using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaEstoque : PassaTempo.frmTelaDePesquisa
    {
        private int tipoOperacao = 0;
        private List<ModelProduto> lista = new List<ModelProduto>();

        public frmPesquisaEstoque()
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreencheGrid(ControleEstoqueAtual.BuscaProdutoEstoqueMinimo(lista));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreencheGrid(lista);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaEstoque_Load(sender, e);
        }

        private void frmPesquisaEstoque_Load(object sender, EventArgs e)
        {
            if (rbProdutoFinal.Checked)
            {
                tipoOperacao = 1;
            }else if (rbMateriaPrima.Checked)
            {
                tipoOperacao = 0;
            }
            lista = ControleEstoqueAtual.BuscaDados(tipoOperacao, txtPesquisa.Text);
            PreencheGrid(lista);          
        }


        private void PreencheGrid(List<ModelProduto> lista)
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = lista;
            ColorirCelulaEstoque(lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaGrid();
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

        private void LimpaGrid()
        {
            txtPesquisa.Clear();
            rbProdutoFinal.Checked = true;
            gridProduto.DataSource = null;
            gridProduto.Refresh();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new ImprimirDocumento(lista);
            pd.PrintPage += this.printDocument1_PrintPage;

            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
            var _with1 = objPrintPreview;
            _with1.Document = pd;
            _with1.WindowState = FormWindowState.Maximized;
            _with1.PrintPreviewControl.Zoom = 1;
            _with1.ShowDialog();
        }

        //EVENTO PARA IMPRESSÂO DOS DADOS
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RelatorioEstoque re = new RelatorioEstoque(sender, e);                      
            re.Relatorio();
        }
    }
}
