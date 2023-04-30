using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SOM, TOM, TD, HT, IEM;
            

            Console.WriteLine("Enter SOM Marks:");
            SOM = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter TOM Marks:");
            TOM = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter TD Marks:");
            TD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter HT Marks:");
            HT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter IEM Marks:");
            IEM = Convert.ToDouble(Console.ReadLine());

            double Avg = (SOM + TOM + TD + HT + IEM) / 5;

            Console.WriteLine("The Avg Marks of 5 Subject is:"+Avg);

            Console.ReadLine();
        }
    }
}
