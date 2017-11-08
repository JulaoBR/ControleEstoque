using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmRastreioDeLotes : PassaTempo.frmTelaDePesquisa
    {

        private List<ModelRelatorioLotes> lista = new List<ModelRelatorioLotes>();

        public frmRastreioDeLotes()
        {
            InitializeComponent();         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
            var _with1 = objPrintPreview;
            _with1.Document = pd;
            _with1.WindowState = FormWindowState.Maximized;
            _with1.PrintPreviewControl.Zoom = 1;
            _with1.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscaDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void txtDataPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtDataPesquisa);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void gridRastreioLotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(gridRastreioLotes.Rows[e.RowIndex].Cells[0].Value);

                    frmCargaDetalhada frmDetalhada = new frmCargaDetalhada(codigo);
                    frmDetalhada.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma linha valida", "Operação Invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BuscaDados()
        {
            ControleLotes control = new ControleLotes();

            if (txtDataPesquisa.Text == string.Empty)
            {
                PreencheGrid(control.RastreioLotes(txtLote.Text, txtPesquisa.Text, null, txtNumeroCarga.Text));
            }
            else
            {
                PreencheGrid(control.RastreioLotes(txtLote.Text, txtPesquisa.Text, Convert.ToDateTime(txtDataPesquisa.Text).ToString("yyyy-MM-dd 00:00:00"), txtNumeroCarga.Text));
            }
        }

        private void LimpaGrid()
        {
            gridRastreioLotes.DataSource = null;
            gridRastreioLotes.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridRastreioLotes.DataSource = tb;

            //ADICIONA O DATATABLE NA VARIAVEL GLOBAL
            foreach (DataRow item in tb.Rows)
            {
                ModelRelatorioLotes model = new ModelRelatorioLotes();

                model.Id_carga = Convert.ToInt32(item[0].ToString());
                model.dsc_cliente = item[1].ToString();
                model.dsc_produto = item[2].ToString();
                model.quantidade = Convert.ToDouble(item[3].ToString());
                model.lote = item[4].ToString();
                model.carregamento = item[5].ToString();

                lista.Add(model);
            }
        }

        private void LimpaCampos()
        {
            txtDataPesquisa.Clear();
            txtLote.Clear();
            txtPesquisa.Clear();
            txtNumeroCarga.Clear();

            LimpaGrid();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RelatorioSaidaLotes re = new RelatorioSaidaLotes(sender,e);
            re.Relatorio(lista);
        }
    }
}
