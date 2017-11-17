﻿using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    public class RelatorioSaidaLotes
    {
        public object sender;
        public System.Drawing.Printing.PrintPageEventArgs e;

        public RelatorioSaidaLotes(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.sender = sender;
            this.e = e;
        }

        //METODO QUE CONSTRÓI O RELATÓRIO A SER GERADO
        public void Relatorio(string lotePesquisado)
        {
            ImprimirDocumentoRastreioLotes doc = (ImprimirDocumentoRastreioLotes)sender;

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

            // Incrementa o contador de página para refletir 
            // a página que esta sendo impressa
            doc.NumeroPagina += 1;

            //Define o valor para linha atual e da impressao
            LinhaAtual = 0;

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 60, MargemDir, 60);

            //CABEÇALHO DO DOCUMENTO=================================================================
            //nome da empresa
                e.Graphics.DrawString("Massas Lott", FonteTitulo, Brushes.Black, MargemEsq + 40, 80, new StringFormat());
                e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDir - 120, 70, new StringFormat());

                e.Graphics.DrawString("RASTREAMENTO DE LOTES", FonteSubTitulo, Brushes.Black, MargemEsq + 215, 109, new StringFormat());

                Image image = Image.FromFile("FOTO.jpg");
                Point pp = new Point(100, 68);
                //imagem/logo se caso quiser colocar um logo
                e.Graphics.DrawImage(image, pp);
            //CABEÇALHO DO DOCUMENTO=================================================================

            //linha de separação
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);

            e.Graphics.DrawString("LOTE PESQUISADO: " + lotePesquisado, FonteNegrito, Brushes.Black, MargemEsq, 140, new StringFormat());


            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 160, MargemDir, 160);
            //campos a serem impressos: cabeçalho
            e.Graphics.DrawString("CARGA", FonteNegrito, Brushes.Black, MargemEsq, 170, new StringFormat());
            e.Graphics.DrawString("CLIENTE", FonteNegrito, Brushes.Black, MargemEsq + 60, 170, new StringFormat());
            e.Graphics.DrawString("PRODUTO", FonteNegrito, Brushes.Black, MargemEsq + 300, 170, new StringFormat());
            e.Graphics.DrawString("QTD", FonteNegrito, Brushes.Black, MargemEsq + 495, 170, new StringFormat());
            e.Graphics.DrawString("LOTE", FonteNegrito, Brushes.Black, MargemEsq + 540, 170, new StringFormat());
            e.Graphics.DrawString("SAIDA", FonteNegrito, Brushes.Black, MargemEsq + 595, 170, new StringFormat());

            //linha de separação
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 190, MargemDir, 190);

            //define quantas linhas por pagina
            LinhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9);

            StringFormat alinhaDireita = new StringFormat();
            alinhaDireita.Alignment = StringAlignment.Far;

            //Aqui sao lidos os dados (deixei pré-feito pra quando estivermos com o banco ja pronto)
            while (LinhaAtual < LinhasPorPagina && doc.Offset < doc.Texto.Count)
            {
                //obtem os valores do datareader
                int cod = Convert.ToInt32(doc.Texto[doc.Offset].Id_carga.ToString());
                var cliente = doc.Texto[doc.Offset].dsc_cliente.ToString();
                var produto = doc.Texto[doc.Offset].dsc_produto.ToString();
                var quantidade = doc.Texto[doc.Offset].quantidade.ToString();
                var lote = doc.Texto[doc.Offset].lote.ToString();
                DateTime carregamento = Convert.ToDateTime(doc.Texto[doc.Offset].carregamento.ToString());

                //inicia a impressao
                PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));

                //imprime os dados relativo ao codigo , nome do produto e preço do produto
                e.Graphics.DrawString(cod.ToString(), FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(cliente.ToString(), FonteNormal, Brushes.Black, MargemEsq + 60, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(produto.ToString(), FonteNormal, Brushes.Black, MargemEsq + 300, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(quantidade.ToString(), FonteNormal, Brushes.Black, MargemEsq + 495, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(lote.ToString(), FonteNormal, Brushes.Black, MargemEsq + 540, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(carregamento.ToString("dd/MM/yyy"), FonteNormal, Brushes.Black, MargemEsq + 580, PosicaoDaLinha, new StringFormat());


                LinhaAtual += 1;
                // move para a proxima linha
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
        
            //-------------------------------------------------------------------------------------------------------------------------
            /// <summary>
            /// finaliza a impressão
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="byvale"></param
        }
    }
}
