using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CONTROL
{
   
    public class ControlePDF
    {
        public void InicializaPdf()
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 14);

                string texte = "MASSAS LOTT";

                //escrever no pdf
                textFormatter.DrawString(texte, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height));


                //centralizar ou direita ou esquerda, o texto
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;

                //salvando o arquivo
                doc.Save("arquivo.pdf");
                System.Diagnostics.Process.Start("arquivo.pdf");
            }

        }
    }
}

