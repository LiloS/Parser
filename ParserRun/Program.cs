using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserLibrary;
using ParserLibrary.DocParsers;
using ParserLibrary.PdfParsers;

namespace ParserRun {
    class Program {
        static void Main(string[] args) {
            try {
                Parser parser = new MicrosoftWordParser();
                parser.Parse(@"D:\Study\Blekanov\DocTest\Numbers_SpecialSymbols.docx");

                parser.SaveTextToFile(@"D:\Study\Blekanov\ResultDocuments\Numbers_SpecialSynbols.txt");
              

            } catch (Exception e) {
                Console.WriteLine(e);
            }
          Console.WriteLine("Process finished1. Press any key to continue.");
            Console.ReadLine();

        }
    }
}
