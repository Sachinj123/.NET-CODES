using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumberOfYearsAndMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Days:");
            int days = Convert.ToInt32(Console.ReadLine());

            double Year = days/ 365;
            double Months = days / 12;

            Console.WriteLine("Number of Years:" + Year);
            Console.WriteLine("Number of Months:" + Months);
            Console.ReadLine();
        }
    }
}
