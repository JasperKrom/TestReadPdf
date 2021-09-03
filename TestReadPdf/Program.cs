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
        }
    }
}
