using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    public class RelatorioEntrada
    {
        int paginaAtual = 1;

        ModelRelatorio rinout = new ModelRelatorio();

        public RelatorioEntrada(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            rinout.sender = sender;
            rinout.e = e;
        }

        //METODO QUE CONSTRÓI O RELATÓRIO A SER GERADO
        public void Relatorio(List<ModelRegistro> Lista, string data, string lote2, string produto2)
        {
            //Variaveis de Linhas.
            float LinhasPorPagina = 0;
            float PosicaoDaLinha = 0;
            int LinhaAtual = 0;
            int TotalRegistro = Lista.Count();

            //Variaveis de Margens.
            float MargemEsq = rinout.e.MarginBounds.Left;
            float MargemSuper = rinout.e.MarginBounds.Top + 100;
            float MargemDir = rinout.e.MarginBounds.Right;
            float MargemInfer = rinout.e.MarginBounds.Bottom;

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

            //Define o valor para linha atual e da impressao
            LinhaAtual = 0;

            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 60, MargemDir, 60);           

            //nome da empresa
            rinout.e.Graphics.DrawString("Massas Lott", FonteTitulo, Brushes.Black, MargemEsq + 40, 80, new StringFormat());

            rinout.e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDir - 120, 70, new StringFormat());

            rinout.e.Graphics.DrawString("RELATÓRIO DE ENTRADA", FonteSubTitulo, Brushes.Black, MargemEsq + 225, 109, new StringFormat());

            Image image = Image.FromFile("FOTO.jpg");
            Point pp = new Point(100, 68);
            //imagem/logo se caso quiser colocar um logo
            rinout.e.Graphics.DrawImage(image, pp);      

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);

            rinout.e.Graphics.DrawString("Data de produção: ", FonteNegrito, Brushes.Black, MargemEsq, 140, new StringFormat());
            rinout.e.Graphics.DrawString(data, FonteNormal, Brushes.Black, MargemEsq + 120, 140, new StringFormat());

            rinout.e.Graphics.DrawString("Lote: ", FonteNegrito, Brushes.Black, MargemEsq + 250, 140, new StringFormat());
            rinout.e.Graphics.DrawString(lote2, FonteNormal, Brushes.Black, MargemEsq + 290, 140, new StringFormat());

            rinout.e.Graphics.DrawString("Produto: ", FonteNegrito, Brushes.Black, MargemEsq + 400, 140, new StringFormat());
            rinout.e.Graphics.DrawString(produto2, FonteNormal, Brushes.Black, MargemEsq + 460, 140, new StringFormat());

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 160, MargemDir, 160);

            //campos a serem impressos: cabeçalho
            rinout.e.Graphics.DrawString("PRODUTO", FonteNegrito, Brushes.Black, MargemEsq, 170, new StringFormat());
            rinout.e.Graphics.DrawString("LOTE", FonteNegrito, Brushes.Black, MargemEsq + 190, 170, new StringFormat());
            rinout.e.Graphics.DrawString("QTD", FonteNegrito, Brushes.Black, MargemEsq + 240, 170, new StringFormat());
            rinout.e.Graphics.DrawString("FABRICAÇÃO", FonteNegrito, Brushes.Black, MargemEsq + 285, 170, new StringFormat());
            rinout.e.Graphics.DrawString("VENCIMENTO", FonteNegrito, Brushes.Black, MargemEsq + 380, 170, new StringFormat());
            rinout.e.Graphics.DrawString("PRODUÇÃO", FonteNegrito, Brushes.Black, MargemEsq + 480, 170, new StringFormat());
            rinout.e.Graphics.DrawString("OBSERVAÇÃO", FonteNegrito, Brushes.Black, MargemEsq + 560, 170, new StringFormat());



            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 190, MargemDir, 190);

            //define quantas linhas por pagina
            LinhasPorPagina = Convert.ToInt32(rinout.e.MarginBounds.Height / FonteNormal.GetHeight(rinout.e.Graphics));

            StringFormat alinhaDireita = new StringFormat();
            alinhaDireita.Alignment = StringAlignment.Far;
            int i = 0;

            //Aqui sao lidos os dados (deixei pré-feito pra quando estivermos com o banco ja pronto)
            while (LinhaAtual < LinhasPorPagina && TotalRegistro > 0)
            {
                //obtem os valores do datareader
                var produto = Lista[i].dsc_produto.ToString();
                var lote = Lista[i].lote.ToString();
                var quantidade = Lista[i].qtd_produto.ToString();
                var fabricacao = Lista[i].data_fabricacao.ToString();
                var vencimento = Lista[i].data_vencimento.ToString();
                DateTime producao = Convert.ToDateTime(Lista[i].data_operacao.ToString());
                var observacao = Lista[i].observacao.ToString();

                //inicia a impressao
                PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(rinout.e.Graphics));

                //imprime os dados relativo ao codigo , nome do produto e preço do produto
                rinout.e.Graphics.DrawString(produto.ToString(), FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(lote.ToString(), FonteNormal, Brushes.Black, MargemEsq + 190, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(quantidade.ToString(), FonteNormal, Brushes.Black, MargemEsq + 240, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(fabricacao.ToString(), FonteNormal, Brushes.Black, MargemEsq + 285, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(vencimento.ToString(), FonteNormal, Brushes.Black, MargemEsq + 370, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(producao.ToString("dd/MM/yyyy"), FonteNormal, Brushes.Black, MargemEsq + 480, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(observacao.ToString(), FonteNormal, Brushes.Black, MargemEsq + 560, PosicaoDaLinha, new StringFormat());              

                LinhaAtual += 1;
                TotalRegistro -= 1;
                i += 1;
            }

            //verifica se continua imprimindo
            if (TotalRegistro > 0)
                rinout.e.HasMorePages = true;
            else
                rinout.e.HasMorePages = false;

            //Rodape - pega data e hora do sistema
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, MargemInfer, MargemDir, MargemInfer); rinout.e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsq, MargemInfer, new StringFormat());
            LinhaAtual += Convert.ToInt32(FonteNormal.GetHeight(rinout.e.Graphics));
            LinhaAtual += 1;
            rinout.e.Graphics.DrawString("ProEstoque", FonteRodape, Brushes.Black, MargemDir - 360, MargemInfer, new StringFormat());
            rinout.e.Graphics.DrawString("Pagina : " + paginaAtual, FonteRodape, Brushes.Black, MargemDir - 50, MargemInfer, new StringFormat());

            //Incrementa o numero da pagina
            paginaAtual += 1;


            //-------------------------------------------------------------------------------------------------------------------------
            /// <summary>
            /// finaliza a impressão
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="byvale"></param
        }
    }
}
