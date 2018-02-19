using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaTotal : PassaTempo.frmTelaDePesquisa
    {
        private List<ModelRegistro> LISTA = new List<ModelRegistro>();
        private string nomeOperacao = "";
        private int tipoProduto = 0;
        private int tipoOperacao = 0;

        public frmPesquisaTotal()
        {
            InitializeComponent();
            gridTotal.AutoGenerateColumns = false;
        }

        private void frmPesquisaTotal_Load(object sender, EventArgs e)
        {
            ControleTotal control = new ControleTotal();

            if (rbEntrada.Checked != false || rbSaida.Checked != false && rbProdutoFinal.Checked != false || rbMateriaPrima.Checked != false)
            {

                DateTime dt1 = Convert.ToDateTime(date01.Text);
                DateTime dt2 = Convert.ToDateTime(date02.Text);
                var aux1 = dt1.ToString("yyyy-MM-dd 00:00:00");
                var aux2 = dt2.ToString("yyyy-MM-dd 00:00:00");

                LISTA = control.CalculaTotal(txtPesquisa.Text, aux1, aux2,tipoProduto , tipoOperacao);
                PreencheGrid();
            }
            
        }

        private void PreencheGrid()
        {
            gridTotal.DataSource = null;
            gridTotal.DataSource = LISTA.ToList();
            gridTotal.Refresh();
        }

        private void btmImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new ImprimirDocumentoEntrada(LISTA);
            pd.PrintPage += this.printDocument1_PrintPage;

            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
            var _with1 = objPrintPreview;
            _with1.Document = pd;
            _with1.WindowState = FormWindowState.Maximized;
            _with1.PrintPreviewControl.Zoom = 1;
            _with1.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaTotal_Load(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            RelatorioTotal re = new RelatorioTotal(sender, e);
            re.Relatorio(txtPesquisa.Text, date01.Text, date02.Text, nomeOperacao );
        }

        private void rbProdutoFinal_CheckedChanged(object sender, EventArgs e)
        {
            tipoProduto = 1;
        }

        private void rbMateriaPrima_CheckedChanged(object sender, EventArgs e)
        {
            tipoProduto = 0;
        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            tipoOperacao = 0;
            nomeOperacao = "ENTRADA";
        }

        private void rbSaida_CheckedChanged(object sender, EventArgs e)
        {
            tipoOperacao = 1;
            nomeOperacao = "SAIDA";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
