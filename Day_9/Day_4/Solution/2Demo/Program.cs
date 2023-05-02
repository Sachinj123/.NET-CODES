using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



//UPGRADED VERSION OF 1DEMO

//WE USE PROTECTED BECAUSE ON THE OBJECT OF PDF WE CAN CALL REMAINING 3 METHODS ALSO 
//IF SOMEONE DIRECTLY CALL SAVE METHOD THEN WE ARE IN PROBLEM THEREFORE WE MAKE ALL THE METHODS PROTECTED
//EXCEPT GENERATE METHOD


namespace _2Demo
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
                    //WE USE PROTECTED BECAUSE ON THE OBJECT OF PDF WE CAN CALL REMAINING 3 METHODS ALSO 
                    //IF SOMEONE DIRECTLY CALL SAVE METHOD THEN WE ARE IN PROBLEM THEREFORE WE MAKE ALL THE METHODS PROTECTED
                    //EXCEPT GENERATE METHOD
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
        protected abstract void Parse();

        protected abstract void Validation();

        protected abstract void Saving();

        public void Generate()
        {
            Parse();
            Validation();
            Saving();
        }

       

    }

    //PDF CLASS IS DEVELOPE BY DEVELOPE BY DEVELOPER-1
    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF is Parsing is Done");
        }
        protected override void Validation()
        {
            Console.WriteLine("PDF is Validation is Done");

        }
        protected override void Saving()
        {
            Console.WriteLine("PDF is Saving is Done");
        }
        //IN THE GENERATE METHOD I AM CALLING ALL 3 METHODS INSTEAD OF CALL 3 DIFF METHODS ON THE OBJECT WE CALL ONLY ONE METHOD
        
    }

    //WORD CLASS IS DEVELOPE BY DEVELOPE BY DEVELOPER-2
    public class WORD : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("WORD is Parsing is Done");
        }
        protected override void Validation()
        {
            Console.WriteLine("WORD is Validation is Done");

        }
        protected override void Saving()
        {
            Console.WriteLine("WORD is Saving is Done");
        }

       
    }

    //EXCEL CLASS IS DEVELOPE BY DEVELOPE BY DEVELOPER-3
    public class EXCEL : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("EXCEL is Parsing is Done");
        }
        protected override void Validation()
        {
            Console.WriteLine("EXCEL is Validation is Done");

        }
        protected override void Saving()
        {
            Console.WriteLine("EXCEL is Saving is Done");
        }

        
    }

    public class Text : Report
    {
        
        protected override void Parse()
        {
            Console.WriteLine("TEXT Parse Done");
        }

        protected override void Saving()
        {
            Console.WriteLine("TEXT Saving Done");
        }

        protected override void Validation()
        {
            Console.WriteLine("TEXT Validation Done");
        }

        public void reValidate()
        {
            Console.WriteLine("TEXT ReValidate Done");
        }

       
    }
}
