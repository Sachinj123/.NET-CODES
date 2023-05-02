using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1:PDF, 2:WORD, 3:EXCEL ");

            int choice = Convert.ToInt32(Console.ReadLine());

            //THIS LOGIC IS DEVELOPED BY DEVELOPER-4
            switch (choice)
            {
                case 1:
                    PDF pdf = new PDF();
                    pdf.Generate();
                    break;

                case 2:
                    WORD word = new WORD();
                    word.Generate();
                    break;

                case 3:
                    EXCEL excel = new EXCEL();
                    excel.Generate();
                    break;

                default:
                    break;

            }
            Console.ReadLine();
        }
    }

    public abstract class Report
    {
        public abstract void Parse();

        public abstract void Validation();

        public abstract void Saving();
       
    }

    //PDF CLASS IS DEVELOPE BY DEVELOPE BY DEVELOPER-1
    public class PDF:Report
    {
        public override void Parse()
        {
            Console.WriteLine("PDF is Parsing is Done");
        }
        public override void Validation()
        {
            Console.WriteLine("PDF is Validation is Done");

        }
        public override void Saving()
        {
            Console.WriteLine("PDF is Saving is Done");
        }
        //IN THE GENERATE METHOD I AM CALLING ALL 3 METHODS INSTEAD OF CALL 3 DIFF METHODS ON THE OBJECT WE CALL ONLY ONE METHOD
        public void Generate()
        {
            Parse();
            Validation();
            Saving();
        }
    }

    //WORD CLASS IS DEVELOPE BY DEVELOPE BY DEVELOPER-2
    public class WORD:Report
    {
        public override void Parse()
        {
            Console.WriteLine("WORD is Parsing is Done");
        }
        public override void Validation()
        {
            Console.WriteLine("WORD is Validation is Done");

        }
        public override void Saving()
        {
            Console.WriteLine("WORD is Saving is Done");
        }

        public void Generate()
        {
            Parse();
            Validation();
            Saving();
        }
    }

    //EXCEL CLASS IS DEVELOPE BY DEVELOPE BY DEVELOPER-3
    public class EXCEL:Report
    {
        public override void Parse()
        {
            Console.WriteLine("EXCEL is Parsing is Done");
        }
        public override void Validation()
        {
            Console.WriteLine("EXCEL is Validation is Done");

        }
        public override void Saving()
        {
            Console.WriteLine("EXCEL is Saving is Done");
        }

        public void Generate()
        {
            Parse();
            Validation();
            Saving();
        }
    }

}
