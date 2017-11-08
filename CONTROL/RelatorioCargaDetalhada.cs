using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CONTROL
{
    public class RelatorioCargaDetalhada
    {
        string RelatorioTitulo = "";
        int paginaAtual = 1;

        ModelRelatorio rinout = new ModelRelatorio();

        public RelatorioCargaDetalhada(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            rinout.sender = sender;
            rinout.e = e;
        }

        //METODO QUE CONSTRÓI O RELATÓRIO A SER GERADO
        public void Relatorio(List<ModelRegistro> Lista, ModelRelatorioCargaDetalhada model)
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


            //CABEÇALHO DO DOCUMENTO=================================================================
            //nome da empresa
            rinout.e.Graphics.DrawString("Massas Lott", FonteTitulo, Brushes.Black, MargemEsq + 40, 80, new StringFormat());
            rinout.e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDir - 120, 70, new StringFormat());
          
            Image image = Image.FromFile("FOTO.jpg");
            Point pp = new Point(100, 68);
            //imagem/logo se caso quiser colocar um logo
            rinout.e.Graphics.DrawImage(image, pp);

            //CABEÇALHO DO DOCUMENTO=================================================================
            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);

            //CABEÇALHO DO PEDIDO====================================================================
            rinout.e.Graphics.DrawString("PEDIDO: ", FonteNegrito, Brushes.Black, MargemEsq , 140, new StringFormat());
            rinout.e.Graphics.DrawString(Convert.ToString(model.cod_carga), FonteNormal, Brushes.Black, MargemEsq + 100, 140, new StringFormat());

            DateTime data = Convert.ToDateTime(model.carregamento);
            rinout.e.Graphics.DrawString("DATA CARREGAMENTO: ", FonteNegrito, Brushes.Black, MargemEsq + 420, 140, new StringFormat());
            rinout.e.Graphics.DrawString(data.ToString("dd/MM/yyyy"), FonteNormal, Brushes.Black, MargemEsq + 580, 140, new StringFormat());

            rinout.e.Graphics.DrawString("CLIENTE: ", FonteNegrito, Brushes.Black, MargemEsq, 160, new StringFormat());
            rinout.e.Graphics.DrawString(model.dsc_cliente, FonteNormal, Brushes.Black, MargemEsq + 100, 160, new StringFormat());
            rinout.e.Graphics.DrawString("ENDEREÇO: ", FonteNegrito, Brushes.Black, MargemEsq, 180, new StringFormat());
            rinout.e.Graphics.DrawString(model.endereco, FonteNormal, Brushes.Black, MargemEsq + 100, 180, new StringFormat());
            rinout.e.Graphics.DrawString("CIDADE: ", FonteNegrito, Brushes.Black, MargemEsq, 200, new StringFormat());
            rinout.e.Graphics.DrawString(model.nome_cidade, FonteNormal, Brushes.Black, MargemEsq + 100, 200, new StringFormat());
            rinout.e.Graphics.DrawString("ESTADO: ", FonteNegrito, Brushes.Black, MargemEsq, 220, new StringFormat());
            rinout.e.Graphics.DrawString(model.nome_estado, FonteNormal, Brushes.Black, MargemEsq + 100, 220, new StringFormat());
            rinout.e.Graphics.DrawString("CEP: " , FonteNegrito , Brushes.Black, MargemEsq + 380, 220, new StringFormat());
            rinout.e.Graphics.DrawString(model.cep, FonteNormal, Brushes.Black, MargemEsq + 420, 220, new StringFormat());
            rinout.e.Graphics.DrawString("COMPRADOR: ", FonteNegrito, Brushes.Black, MargemEsq, 240, new StringFormat());
            rinout.e.Graphics.DrawString(model.comprador, FonteNormal, Brushes.Black, MargemEsq + 240, 140, new StringFormat());

            //CABEÇALHO DO PEDIDO====================================================================


            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 270, MargemDir, 270);

            //campos a serem impressos: cabeçalho
            rinout.e.Graphics.DrawString("ID", FonteNegrito, Brushes.Black, MargemEsq, 280, new StringFormat());
            rinout.e.Graphics.DrawString("PRODUTO", FonteNegrito, Brushes.Black, MargemEsq + 90, 280, new StringFormat());
            rinout.e.Graphics.DrawString("LOTES", FonteNegrito, Brushes.Black, MargemEsq + 320, 280, new StringFormat());
            rinout.e.Graphics.DrawString("QTD TOTAL", FonteNegrito, Brushes.Black, MargemEsq + 570, 280, new StringFormat());

            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 300, MargemDir, 300);


            //define quantas linhas por pagina
            LinhasPorPagina = Convert.ToInt32(rinout.e.MarginBounds.Height / FonteNormal.GetHeight(rinout.e.Graphics));

            StringFormat alinhaDireita = new StringFormat();
            alinhaDireita.Alignment = StringAlignment.Far;
            int i = 0;

            //Aqui sao lidos os dados (deixei pré-feito pra quando estivermos com o banco ja pronto)
            while (LinhaAtual < LinhasPorPagina && TotalRegistro > 0)
            {
                //obtem os valores do datareader
                int cod = Convert.ToInt32(Lista[i].Fk_produto.ToString());
                var produto = Lista[i].dsc_produto.ToString();
                var quantidade = Lista[i].qtd_produto.ToString();
                var lote = Lista[i].lote.ToString();

                //inicia a impressao
                PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(rinout.e.Graphics));

                //imprime os dados relativo ao codigo , nome do produto e preço do produto
                rinout.e.Graphics.DrawString(cod.ToString(), FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(produto.ToString(), FonteNormal, Brushes.Black, MargemEsq + 90, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(lote.ToString(), FonteNormal, Brushes.Black, MargemEsq + 320, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(quantidade.ToString(), FonteNormal, Brushes.Black, MargemEsq + 570, PosicaoDaLinha, new StringFormat());

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
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, MargemInfer, MargemDir, MargemInfer);
            rinout.e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsq, MargemInfer, new StringFormat());
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
