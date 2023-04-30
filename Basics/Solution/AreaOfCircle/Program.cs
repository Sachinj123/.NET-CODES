using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of the Cicle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = (3.14f * radius*radius);
            Console.WriteLine("The Area of the Cicle is:"+area);
            Console.ReadLine();
        }
    }
}
