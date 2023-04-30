using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle:");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate:");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number of Years:");
            double years = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principle * rate * years) / 100;

            Console.WriteLine("The Simple Interest : "+simpleInterest);
            Console.ReadLine();
        }
    }
}
