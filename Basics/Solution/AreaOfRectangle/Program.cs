using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the Rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Width of the Rectangle:");
            int width = Convert.ToInt32(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("Area of RectAngle is :" + area);
            Console.ReadLine();

        }
        
    }
}
