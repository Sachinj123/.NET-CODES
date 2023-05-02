using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int result = num1 + num2;
            Console.WriteLine("ADDITION :"+result);

            int result1 = num1 - num2;
            Console.WriteLine("SUB :"+result1);

            int result2 = num1 * num2;
            Console.WriteLine("MULTIPLICATION :"+result2);

            double result3 = num1 / num2;
            Console.WriteLine("DIVISION :" + result3);

            Console.ReadLine();

        }
    }
}
