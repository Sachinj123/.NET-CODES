using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DemoLAMBDAExpression
{
    delegate string myDelegate(int id ,string name);
    internal class Program
    {
        static void Main(string[] args)
        {

            myDelegate pointer = (id,name) =>    // (=>) it is known as Lambda Operator or goes to
            {
                return id+" Hello " + name;
            };

            string message = pointer(1,"Sachin");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
