using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CONTROL
{
    public class RelatorioEntrada
    {
        int paginaAtual = 1;

        public object sender;
        public System.Drawing.Printing.PrintPageEventArgs e;

        public RelatorioEntrada(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.sender = sender;
            this.e = e;
        }

        //METODO QUE CONSTRÓI O RELATÓRIO A SER GERADO
        public void Relatorio(string data, string lote2, string produto2)
        {
            // Recupera o documento que enviou este evento.
            ImprimirDocumentoEntrada doc = (ImprimirDocumentoEntrada)sender;

            //Variaveis de Linhas.
            float LinhasPorPagina = 0;
            float PosicaoDaLinha = 0;
            int LinhaAtual = 0;


            //Variaveis de Margens.
            float MargemEsq = e.MarginBounds.Left;
            float MargemSuper = e.MarginBounds.Top + 100;
            float MargemDir = e.MarginBounds.Right;
            float MargemInfer = e.MarginBounds.Bottom;

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
            doc.NumeroPagina += 1;

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 60, MargemDir, 60);           

            //nome da empresa
            e.Graphics.DrawString("Massas Lott", FonteTitulo, Brushes.Black, MargemEsq + 40, 80, new StringFormat());

           e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDir - 120, 70, new StringFormat());

            e.Graphics.DrawString("RELATÓRIO DE ENTRADA", FonteSubTitulo, Brushes.Black, MargemEsq + 225, 109, new StringFormat());

            Image image = Image.FromFile("FOTO.jpg");
            Point pp = new Point(100, 68);
            //imagem/logo se caso quiser colocar um logo
            e.Graphics.DrawImage(image, pp);      

            //linha de separação
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);

            e.Graphics.DrawString("Data de produção: ", FonteNegrito, Brushes.Black, MargemEsq, 140, new StringFormat());
            e.Graphics.DrawString(data, FonteNormal, Brushes.Black, MargemEsq + 120, 140, new StringFormat());

            e.Graphics.DrawString("Lote: ", FonteNegrito, Brushes.Black, MargemEsq + 250, 140, new StringFormat());
            e.Graphics.DrawString(lote2, FonteNormal, Brushes.Black, MargemEsq + 290, 140, new StringFormat());

            e.Graphics.DrawString("Produto: ", FonteNegrito, Brushes.Black, MargemEsq + 400, 140, new StringFormat());
            e.Graphics.DrawString(produto2, FonteNormal, Brushes.Black, MargemEsq + 460, 140, new StringFormat());

            //linha de separação
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 160, MargemDir, 160);

            //campos a serem impressos: cabeçalho
            e.Graphics.DrawString("PRODUTO", FonteNegrito, Brushes.Black, MargemEsq, 170, new StringFormat());
            e.Graphics.DrawString("LOTE", FonteNegrito, Brushes.Black, MargemEsq + 190, 170, new StringFormat());
            e.Graphics.DrawString("QTD", FonteNegrito, Brushes.Black, MargemEsq + 240, 170, new StringFormat());
            e.Graphics.DrawString("FABRICAÇÃO", FonteNegrito, Brushes.Black, MargemEsq + 285, 170, new StringFormat());
            e.Graphics.DrawString("VENCIMENTO", FonteNegrito, Brushes.Black, MargemEsq + 380, 170, new StringFormat());
            e.Graphics.DrawString("PRODUÇÃO", FonteNegrito, Brushes.Black, MargemEsq + 480, 170, new StringFormat());
            e.Graphics.DrawString("OBSERVAÇÃO", FonteNegrito, Brushes.Black, MargemEsq + 560, 170, new StringFormat());



            //linha de separação
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 190, MargemDir, 190);

            //define quantas linhas por pagina
            LinhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9);

            StringFormat alinhaDireita = new StringFormat();
            alinhaDireita.Alignment = StringAlignment.Far;

            string loteAux = doc.Texto[doc.Offset].lote;

            //Aqui sao lidos os dados (deixei pré-feito pra quando estivermos com o banco ja pronto)
            while (LinhaAtual < LinhasPorPagina && doc.Offset < doc.Texto.Count)
            {
                //obtem os valores do datareader
                var produto = doc.Texto[doc.Offset].Dsc_produto.ToString();
                var lote = doc.Texto[doc.Offset].lote.ToString();
                var quantidade = doc.Texto[doc.Offset].qtd_produto.ToString();
                var fabricacao = doc.Texto[doc.Offset].data_fabricacao.ToString();
                var vencimento = doc.Texto[doc.Offset].data_vencimento.ToString();
                DateTime producao = Convert.ToDateTime(doc.Texto[doc.Offset].data_operacao.ToString());
                var observacao = doc.Texto[doc.Offset].observacao.ToString();

                //inicia a impressao
                PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));

                //imprime os dados relativo ao codigo , nome do produto e preço do produto
                e.Graphics.DrawString(produto.ToString(), FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(lote.ToString(), FonteNormal, Brushes.Black, MargemEsq + 190, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(quantidade.ToString(), FonteNormal, Brushes.Black, MargemEsq + 240, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(fabricacao.ToString(), FonteNormal, Brushes.Black, MargemEsq + 285, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(vencimento.ToString(), FonteNormal, Brushes.Black, MargemEsq + 380, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(producao.ToString("dd/MM/yyyy"), FonteNormal, Brushes.Black, MargemEsq + 480, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(observacao.ToString(), FonteNormal, Brushes.Black, MargemEsq + 560, PosicaoDaLinha, new StringFormat());

                if (!loteAux.Equals(doc.Texto[doc.Offset].lote))
                {
                    //linha de separação
                    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, PosicaoDaLinha, MargemDir, PosicaoDaLinha);
                    loteAux = doc.Texto[doc.Offset].lote;
                }


                LinhaAtual += 1;
                doc.Offset += 1;
            }

            //verifica se continua imprimindo
            if (doc.Offset < doc.Texto.Count)
                e.HasMorePages = true;
            else
                doc.Offset = 0;

            //Rodape - pega data e hora do sistema
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, MargemInfer, MargemDir, MargemInfer);
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsq, MargemInfer, new StringFormat());
            LinhaAtual += Convert.ToInt32(FonteNormal.GetHeight(e.Graphics));
            LinhaAtual += 1;
            e.Graphics.DrawString("ProEstoque", FonteRodape, Brushes.Black, MargemDir - 360, MargemInfer, new StringFormat());
            e.Graphics.DrawString("Pagina : " + doc.NumeroPagina, FonteRodape, Brushes.Black, MargemDir - 50, MargemInfer, new StringFormat());

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
