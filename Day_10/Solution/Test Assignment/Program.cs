using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment
{
   public delegate string myDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            A aObj = new A();

            B bObj = new B();

            myDelegate pointer = new myDelegate(bObj.M2);

            aObj.M1(pointer);

            Console.ReadLine();

        }
    }

    public class A
    {
        public void M1(myDelegate pointer)
        {
            Console.WriteLine(pointer());

        }
    }

    public class B
    {
        public string M2()
        {
            return "M2 From B";
        }
    }
}
