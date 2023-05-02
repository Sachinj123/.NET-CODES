using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Demo_NewSyntaxForGetterandSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str1 = "SACHIN";
            string str2 = "JADHAV";
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);

            //SEALED KEYWORD IS APPLICABLE ON CLASS,METHOD,AND GETTER SETTER PROPERTIES

            Console.WriteLine("Enter Some Data:");
            string data = Console.ReadLine();

            // HERE WE Dont MAKE THE MyUtilityClass static below and method static
            // therefore we have to create the object of MyUtilityClass

            // MyUtilityClass obj = new MyUtilityClass();
            // bool result = obj.CheckForValidEmailAddress(data);


            //HERE WE MAKE THE MyUtilityClass static below and method also static
            bool result = MyUtilityClass.CheckForValidEmailAddress(data);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }

    public static class MyUtilityClass
    {
        public static bool CheckForValidEmailAddress(string str)
        {
            return str.Contains("@"); 
        }
    }


    /* public class Emp
     {
         //THIS IS THE SHORTER WAY TO DECLARE THE GETTER AND SETTER
         // USE -----> "prop" and press 2 times tab

         // THESE ARE THE GETTER AND SETTERS ARE DECLARED
         // AND C# COMPILER AUTOMATIC GENERATE PRIVATE VARIABLE OF EMP CLASS

         // LIKE private id,name,salary

         // jar aplyala getter and setter la manipulation karaycha
         //nasel tr ha syntax use karaycha

         //With the use of this syntax we just set and get the values

         //NORMAL WAY TO DECLARE THE SYNTAX OF GETTER AND SETTER
         //HERE WE MANUALLY WRITE THE PRIVATE VARIABLE (_AGE)
         private int _Age;

         public int Age
         {
             get { return _Age; }
             set { _Age = value; }
         }

         //SHORTER SYNTAX
         public int id { get; set; }

         public string Name { get; set; }

         public float Salary { get; set; }

     }*/


}
