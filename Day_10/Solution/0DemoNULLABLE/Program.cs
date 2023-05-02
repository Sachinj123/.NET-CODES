using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0DemoNULLABLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int? salary = null;
            // int? salary = 0;

            //Nullable<int> salary = null;

            //Statement on Line No 13 and 16 are Exactly similar
            //It is depends on you which syntax is use

            // (?) ----> It Indicates Nullable 
            //If we want to store the null value to any "Int" value then we use "NULLABLE"
            //Because "Value Type" is storing bydefault 0 

            if (salary.HasValue)
            {
                Console.WriteLine("Salary Holds a Value");
            }
            else
            {
                Console.WriteLine("Salary is NULL");
            }

            Console.ReadLine();
        }
    }
}
