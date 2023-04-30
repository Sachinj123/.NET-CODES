using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            
            int p = 100;
            int q = 200;

            Console.WriteLine("BEFORE SWAPPING p= "+p.ToString()+"and q ="+q.ToString());
            math.Swap(ref p, ref q);
            Console.WriteLine("AFTER SWAPPING p= " + p.ToString() + "and q =" + q.ToString());

            Maths math1 = new Maths();

            double p1 = 10.55;
            double q1 = 20.55;

            Console.WriteLine("BEFORE SWAPPING p1= " + p1.ToString() + "and q1 =" + q1.ToString());
            math.Swap(ref p1, ref q1);
            Console.WriteLine("AFTER SWAPPING p1= " + p1.ToString() + "and q1 =" + q1.ToString());

            Console.ReadLine();
        }
    }

    public class Maths
    {
        public int Add(ref int x,ref int y)
        {
            return x + y;
        }

        public void Swap(ref int x,ref int y)
        {
            int z;
            z = x;
            x = y;
            y = z;

        }

        public void Swap(ref double x, ref double y)
        {
            double z;
            z = x;
            x = y;
            y = z;

        }
    }
}
