using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhrenheitToCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temp in Farhrenheit:");
            double Farhrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (5 * (Farhrenheit - 32) / 9);

            Console.WriteLine("The Temp in Celsius:" + celsius);
            Console.ReadLine();
        }
    }
}
