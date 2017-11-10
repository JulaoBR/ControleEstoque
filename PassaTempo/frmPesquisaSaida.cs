using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaSaida : PassaTempo.frmTelaDePesquisa
    {
        private int opcao = 0;
        public int codigo_carga = 0;
        private int seletor = 1; //1 = nome , 2 = codigo carga, 3 = data carregamento
        private List<ModelCarga> lista = new List<ModelCarga>();

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

            foreach (DataRow item in tb.Rows)
            {
                ModelCarga carga = new ModelCarga();

                carga.Id_carga = Convert.ToInt32(item[0].ToString());
                carga.nome_cliente = item[1].ToString();
                carga.endereco = item[2].ToString();
                carga.data_carregamento = item[3].ToString();
                carga.nome_comprador = item[4].ToString();

                lista.Add(carga);
            }
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
                    else if (opcao == 3)
                    {
                        codigo_carga = codigo;
                        this.Dispose();
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

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new ImprimirDocumento(lista);
            doc.PrintPage += this.printDocument1_PrintPage;

            PrintDialog dialogo = new PrintDialog();
            dialogo.Document = doc;

            //  Se o usuário clicar em OK , imprime o documento
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                
                    PrintPreviewDialog ppdlg = new PrintPreviewDialog();
                    ppdlg.Document = doc;
                    ppdlg.ShowDialog();
                
                
                    doc.Print();
                
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Recupera o documento que enviou este evento.
            ImprimirDocumento doc = (ImprimirDocumento)sender;

            // Define a fonte e determina a altura da linha
            using (Font fonte = new Font("Verdana", 10))
            {
                float alturaLinha = fonte.GetHeight(e.Graphics);

                // Cria as variáveis para tratar a posição na página
                float MargemEsq = e.MarginBounds.Left;
                float MargemSuper = e.MarginBounds.Top;
                float MargemDir = e.MarginBounds.Right;
                float MargemInfer = e.MarginBounds.Bottom;
                float PosicaoDaLinha = 0;
                float LinhaAtual = 0;
                int i = 0;

                Pen CanetaDaImpressora = new Pen(Color.Black, 1);
                Pen CanetaDaImpressora2 = new Pen(Color.Black, 1);

                //Variaveis de Fontes.
                Font FonteNegrito = default(Font);
                Font FonteTitulo = default(Font);
                Font FonteSubTitulo = default(Font);
                Font FonteRodape = default(Font);
                Font FonteNormal = default(Font);

                //Define efeitos das fontes.
                FonteNegrito = new Font("Arial", 9, FontStyle.Bold);
                FonteTitulo = new Font("Arial", 18, FontStyle.Bold);
                FonteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
                FonteRodape = new Font("Arial", 9, FontStyle.Bold);
                FonteNormal = new Font("Arial", 9);

                // Incrementa o contador de página para refletir 
                // a página que esta sendo impressa
                doc.NumeroPagina += 1;


                e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 60, MargemDir, 60);
                e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 160, MargemDir, 160);

                //nome da empresa
                e.Graphics.DrawString("Massas Lott", FonteTitulo, Brushes.Black, MargemEsq + 40, 80, new StringFormat());

                e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDir - 120, 70, new StringFormat());

                e.Graphics.DrawString(" RELATÓRIO DE ESTOQUE", FonteSubTitulo, Brushes.Black, MargemEsq + 225, 109, new StringFormat());

                Image image = Image.FromFile("FOTO.jpg");
                Point pp = new Point(100, 68);
                //imagem/logo se caso quiser colocar um logo
                e.Graphics.DrawImage(image, pp);

                //linha de separação
                e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);



                // Imprime toda a informação que cabe na página
                // O laço termina quando a próxima linha 
                // iria passar a borda da margem ou quando não 
                // houve mais linhas a imprimir
                while ((MargemSuper + LinhaAtual) < e.MarginBounds.Bottom &&
                  doc.Offset <= doc.Texto.Count)
                {
                    PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));


                    e.Graphics.DrawString(doc.Texto[i].nome_cliente, FonteNormal,
                     Brushes.Black, MargemEsq + 150, PosicaoDaLinha, new StringFormat());

                     // move para a proxima linha
                     doc.Offset += 1;

                     // Move uma linha para baixo (proxima linha)
                     MargemSuper += alturaLinha;

                    i++;
                }

                if (doc.Offset < doc.Texto.Count)
                {
                    // Havendo ainda pelo menos mais uma página.
                    // Sinaliza o evento para disparar novamente
                    e.HasMorePages = true;
                }
                else
                {
                    // A impressão terminou
                    doc.Offset = 0;
                }
            }
        }
    }
}
