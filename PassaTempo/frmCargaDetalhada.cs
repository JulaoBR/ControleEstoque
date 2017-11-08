using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCargaDetalhada : Form
    {
        private int codigo = 0;
        private List<ModelRegistro> lista = new List<ModelRegistro>();
        private ModelRelatorioCargaDetalhada model = new ModelRelatorioCargaDetalhada();

        public frmCargaDetalhada(int codigo)
        {
            InitializeComponent();
            gridCarga.AutoGenerateColumns = false;
            this.codigo = codigo;
        }

        private void frmCargaDetalhada_Load(object sender, EventArgs e)
        {
            ControleCarga controlCarga = new ControleCarga();
            ControleRegistro controlRegistro = new ControleRegistro();

            txtPedido.Text = Convert.ToString(codigo);

            model = controlCarga.BuscaCargaDetalhada(codigo);
            lista = controlRegistro.PreencheListaProdutos(codigo);

            PreencheCampos();
            AtualizaGrid();
            AtualizaInfo();
        }

        private void PreencheCampos()
        {
            txtCodCliente.Text = Convert.ToString(model.cod_cliente);
            DateTime data = Convert.ToDateTime(model.carregamento);
            txtDataCarregamento.Text = data.ToString("dd/MM/yyyy");
            txtNomeCliente.Text = model.dsc_cliente;
            txtEndereco.Text = model.endereco;
            txtCidade.Text = model.nome_cidade;
            txtEstado.Text = model.nome_estado;
            txtCep.Text = model.cep;
            txtComprador.Text = model.comprador;
        }

        private void AtualizaGrid()
        {
            gridCarga.DataSource = null;
            gridCarga.DataSource = lista;
            gridCarga.ClearSelection();
        }

        private void AtualizaInfo()
        {
            double aux = 0, aux1 = 0, aux2 = 0;
            foreach (var item in lista)
            {               
                aux += item.qtd_produto;
                aux1 += item.pesoLiquido;
                aux2 += item.pesoBruto;
            }
            lbTotalItens.Text = Convert.ToString(lista.Count);
            lbTotaCaixas.Text = Convert.ToString(string.Format("{0:N}", aux));
            model.totalCaixa = aux;
            lbPesoLiquido.Text = Convert.ToString(string.Format("{0:N}", aux1));
            model.pesoLiquido = aux1;
            lbPesoBruto.Text = Convert.ToString(string.Format("{0:N}", aux2));
            model.pesoBruto = aux2;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RelatorioCargaDetalhada re = new RelatorioCargaDetalhada(sender, e);
            re.Relatorio(lista, model);
        }

        private void btnImprimirCarga_Click(object sender, EventArgs e)
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
    }
}
