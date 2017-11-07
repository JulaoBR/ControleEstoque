using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    public class RelatorioEstoque
    {
        string RelatorioTitulo = "";
        int paginaAtual = 1;

        ModelRelatorio rinout = new ModelRelatorio();

        public RelatorioEstoque(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            rinout.sender = sender;
            rinout.e = e;
        }

        //METODO QUE CONSTRÓI O RELATÓRIO A SER GERADO
        public void Relatorio(List<ModelProduto> Lista)
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
            FonteTitulo = new Font("Arial", 15, FontStyle.Bold);
            FonteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
            FonteRodape = new Font("Arial", 9, FontStyle.Bold);
            FonteNormal = new Font("Arial", 9);

            //Define o valor para linha atual e da impressao
            LinhaAtual = 0;

            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 60, MargemDir, 60);
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 160, MargemDir, 160);

            //nome da empresa
            rinout.e.Graphics.DrawString("Massas Lott", FonteTitulo, Brushes.Black, MargemEsq + 270, 70, new StringFormat());

            rinout.e.Graphics.DrawString(" Relatório de ESTOQUE", FonteSubTitulo, Brushes.Black, MargemEsq + 235, 105, new StringFormat());

            Image image = Image.FromFile("FOTO.jpg");
            Point pp = new Point(100, 68);
            //imagem/logo se caso quiser colocar um logo
            rinout.e.Graphics.DrawImage(image, pp);
            rinout.e.Graphics.DrawString(RelatorioTitulo, FonteSubTitulo, Brushes.Black, MargemEsq + 70, 110, new StringFormat());


            //linha de separação
            rinout.e.Graphics.DrawLine(CanetaDaImpressora, MargemEsq, 130, MargemDir, 130);

            //campos a serem impressos: cabeçalho
            rinout.e.Graphics.DrawString("CÓDIGO", FonteNegrito, Brushes.Black, MargemEsq, 170, new StringFormat());
            rinout.e.Graphics.DrawString("PRODUTO", FonteNegrito, Brushes.Black, MargemEsq + 150, 170, new StringFormat());
            rinout.e.Graphics.DrawString("QUANTIDADE", FonteNegrito, Brushes.Black, MargemEsq + 550, 170, new StringFormat());

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

                PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(rinout.e.Graphics));

                //obtem os valores do datareader
                int cod = Convert.ToInt32(Lista[i].Id_produto.ToString());
                var produto = Lista[i].DscProduto.ToString();
                var quantidade = Lista[i].qtd_estoque.ToString();

                //inicia a impressao
                PosicaoDaLinha = MargemSuper + (LinhaAtual * FonteNormal.GetHeight(rinout.e.Graphics));

                //imprime os dados relativo ao codigo , nome do produto e preço do produto
                rinout.e.Graphics.DrawString(cod.ToString(), FonteNormal, Brushes.Black, MargemEsq, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(produto.ToString(), FonteNormal, Brushes.Black, MargemEsq + 150, PosicaoDaLinha, new StringFormat());
                rinout.e.Graphics.DrawString(quantidade.ToString(), FonteNormal, Brushes.Black, MargemEsq + 580, PosicaoDaLinha, new StringFormat());


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
