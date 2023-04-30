using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DemoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            int result = math.Add(10, 20);
            Console.WriteLine("Add RESULT:"+result);

            int result1 = math.Mul(10, 20);
            Console.WriteLine("MUL RESULT:" + result1);

            Console.ReadLine();
        }
        
    }

    public interface A
    {
        int Add(int x , int y);

        int Sub(int x , int y);
    }

    public interface B
    {
        int Add(int x , int y);

        int Mul(int x , int y);
    }

    public class Maths : A, B
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Sub(int x, int y)
        {
            return x- y;
        }
    }
}
