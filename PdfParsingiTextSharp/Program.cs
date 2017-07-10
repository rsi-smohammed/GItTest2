using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PdfParsingiTextSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var pp = @"C:\tempp\bb.pdf"; //testingg
            Console.WriteLine(ExtractTextFromPdf(pp));//testing agaion ghg

        }

        public static string ExtractTextFromPdf(string path)//test 7
        {//test  999

            try
            {
                using (PdfReader reader = new PdfReader(path))//
                {
                    StringBuilder text = new StringBuilder();

                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }

                    return text.ToString();
                }
            }
            catch (Exception ex)
            {

                var sdfsdfs = "";
            }
            return "";
        }
    }
}
