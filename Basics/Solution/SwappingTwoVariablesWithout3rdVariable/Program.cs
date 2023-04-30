using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingTwoVariablesWithout3rdVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping:" + num1 + " " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping:"+num1+ " " + num2);
            Console.ReadLine();
        }
    }
}
