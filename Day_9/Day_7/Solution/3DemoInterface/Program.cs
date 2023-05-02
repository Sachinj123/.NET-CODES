using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;



//HERE WE APPLY IMPLEMENTS ALL METHOD EXPLICITLYY 
//THE INTERFACE METHOD ONLY CALL THROUGH THE LIKE LINE NO 18 AND 21
//WE CANT CALL METHOD ON THE REFERENCE OF MATHS CLASS


namespace _3DemoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new Maths();
            Console.WriteLine(a.Add(10,20));

            B b = new Maths();
            Console.WriteLine(b.Add(10, 20));
            
            Console.ReadLine();
        }
    }

    public interface A
    {
        int Add(int x, int y);

        int Sub(int x, int y);
    }

    public interface B
    {
        int Add(int x, int y);

        int Mul(int x, int y);
    }

    public class Maths : A, B
    {
        int A.Add(int x, int y)
        {
            return x + y+100;
        }

        int B.Add(int x, int y)
        {
            return x + y;
        }

        int B.Mul(int x, int y)
        {
            return x * y;
        }

        int A.Sub(int x, int y)
        {
            return x - y;
        }
    }
}
