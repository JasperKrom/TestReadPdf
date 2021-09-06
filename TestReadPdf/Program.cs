using IronPdf;
using System;

namespace TestReadPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert file location of Pdf File:");
            var fileLocation = Console.ReadLine();
            var pdf = new PdfDocument(fileLocation);

            Console.WriteLine($"Security settings edit: {pdf.SecuritySettings.AllowUserEdits}");

            //Fails here
            var ForegroundStamp = new IronPdf.Editing.HtmlStamp() { Html = "<h2 style='color:red'>copyright 2018 ironpdf.com", Width = 50, Height = 50, Opacity = 50, Rotation = -45, ZIndex = IronPdf.Editing.HtmlStamp.StampLayer.OnTopOfExistingPDFContent };
            pdf.StampHTML(ForegroundStamp);
        }
    }
}
