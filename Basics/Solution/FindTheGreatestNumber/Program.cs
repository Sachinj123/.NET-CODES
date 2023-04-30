using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheGreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("First Number is Greatest:" + num1);
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Second Number is Greatest:" + num2);
            }

            else
            {
                Console.WriteLine("Third Number is Greatest:" + num3);
            }
            Console.ReadLine();
        }
    }
}
