using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _0Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1:PDF, 2:WORD, 3:EXCEL ");
            
            int choice = Convert.ToInt32(Console.ReadLine());   

            switch(choice)
            {
                case 1:
                    PDF pdf = new PDF();
                    pdf.Parse();
                    pdf.Validation();
                    pdf.Saving();
                    break;

                case 2:
                    WORD word = new WORD();
                    word.Parse();
                    word.Validation();
                    word.Saving();
                    break;

                case 3:
                    EXCEL excel= new EXCEL();
                    excel.Parse();
                    excel.Validation(); 
                    excel.Saving();
                    break;

                default :
                    break;

            }
            Console.ReadLine();
        }
    }
    public class PDF
    {
        public void Parse()
        {
            Console.WriteLine("PDF is Parsing is Done");
        }
        public void Validation()
        {
            Console.WriteLine("PDF is Validation is Done");
            
        }
        public void Saving()
        {
            Console.WriteLine("PDF is Saving is Done");
        }
    }

    public class WORD
    {
        public void Parse()
        {
            Console.WriteLine("WORD is Parsing is Done");
        }
        public void Validation()
        {
            Console.WriteLine("WORD is Validation is Done");

        }
        public void Saving()
        {
            Console.WriteLine("WORD is Saving is Done");
        }
    }

    public class EXCEL
    {
        public void Parse()
        {
            Console.WriteLine("EXCEL is Parsing is Done");
        }
        public void Validation()
        {
            Console.WriteLine("EXCEL is Validation is Done");

        }
        public void Saving()
        {
            Console.WriteLine("EXCEL is Saving is Done");
        }
    }


}
