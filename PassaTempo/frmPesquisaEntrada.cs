using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaEntrada : PassaTempo.frmTelaDePesquisa
    {

        public int codigo = 0;
        private int ajuste = 0;
        private int saida = 0;
        private List<ModelRegistro> lista = new List<ModelRegistro>();

        public frmPesquisaEntrada()
        {
            InitializeComponent();
        }

        private void frmPesquisaEntrada_Load(object sender, EventArgs e)
        {
            
        }        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new ImprimirDocumentoEntrada(lista);
            pd.PrintPage += this.printDocument1_PrintPage;
            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();

            var _with1 = objPrintPreview;
            _with1.Document = pd;
            _with1.WindowState = FormWindowState.Maximized;
            _with1.PrintPreviewControl.Zoom = 1;
            _with1.ShowDialog();
        }

        private void rbAjuste_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAjuste.Checked)
            {
                ajuste = 1;
            }
            else
            {
                ajuste = 0;
            }
            
        }

        private void checkSaidas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaidas.Checked)
            {
                saida = 1;
            }
            else
            {
                saida = 0;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            BuscaDados();
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void txtPesquisaData_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtPesquisaData);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void BuscaDados()
        {
            ControleRegistro registro = new ControleRegistro();

            PreencheGrid(registro.BuscaString(txtPesquisa.Text, txtPesquisaData.Text, txtLote.Text, ajuste, saida));
        }

        private void LimpaGrid()
        {
            gridEntrada.DataSource = null;
            gridEntrada.Refresh();            
        }

        private void PreencheGrid(DataTable tb)
        {            
            gridEntrada.DataSource = tb;

            //ADICIONA O DADOS DO DATATABLE NA LISTA PARA IMPRESSÂO
            foreach (DataRow item in tb.Rows)
            {
                ModelRegistro model = new ModelRegistro();

                model.dsc_produto = item[1].ToString();
                model.lote = item[2].ToString();
                model.qtd_produto = Convert.ToDouble(item[3].ToString());
                model.data_fabricacao = item[4].ToString();
                model.data_vencimento = item[5].ToString();
                model.data_operacao = item[6].ToString();
                model.observacao = item[7].ToString();

                lista.Add(model);
            }                      
        }

        private void gridEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridEntrada.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaCampo()
        {
            txtLote.Clear();
            txtPesquisa.Clear();
            txtPesquisaData.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RelatorioEntrada re = new RelatorioEntrada(sender, e);
            re.Relatorio(txtPesquisaData.Text, txtLote.Text, txtPesquisa.Text);
        }
    }
}
