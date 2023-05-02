using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DemoDELEGATES
{
    delegate int myDelegate(int p, int q);
    delegate void sayHiDelegate(string s);

    internal class Program
    {
        static void Main(string[] args)
        {
           // myDelegate md = new myDelegate(Add);

           //THE SIGNATURE OF THE "ADD" & "SUB" IS SAME THEREFORE IS NO NEED TO CREATE DIFF DELEGATE

            myDelegate md = new myDelegate(Sub);
            int result = md(10, 20);

            //int result = Add(10,20);

            //HERE WE CREATE DIFF DELEGATE BECAUSE SIGNATURE IS DIFF IT TAKES "STRING" INPUT

            sayHiDelegate shd = new sayHiDelegate(SayHi);
            shd("SACHIN");

            Console.WriteLine("RESULT is: "+result.ToString());
            Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x,int y)
        {
            return x - y;
        }

        public static void SayHi(string name)
        {
            Console.WriteLine(" Hi "+ name);
        }
    }
}
