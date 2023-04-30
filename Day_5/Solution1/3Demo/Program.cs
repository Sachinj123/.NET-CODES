using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//THE FOLLOWING PROGRAM IS THE EXAMPLE OF METHOD OVERLOADING
namespace _3Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Maths maths = new Maths();
            int result1 = maths.Add(10, 20);
            int result2 = maths.Add(10, 20, 30);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }

    public class Maths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
