using GroupDocs.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nlpSurvey
{
    public class Survey
    {
        public static void surveys()
        {
           
                Console.WriteLine("in" + AppDomain.CurrentDomain.BaseDirectory);
            try
            {
                Console.WriteLine("try");
                string fileName = "test.docx";
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                Console.WriteLine("out" + filePath);
                Parser parser1 = new Parser(filePath);
                Console.WriteLine("out12", filePath);
                // Create an instance of Parser class
                using (Parser parser = new Parser("C:\\Users\\admin\\Documents\\test.docx")) // NOTE: Put here actual path for your document
                {
                    Console.WriteLine("sdfxcgvhbjn");
                    // Extract a text to the reader
                    using (TextReader reader = parser.GetText())
                    {
                        // Print an extracted text (or "not supported" message)
                        Console.WriteLine(reader == null ? "Text extraction isn't supported" : reader.ReadToEnd());
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("exception", e);
            }
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzz");
        }
    }
}
