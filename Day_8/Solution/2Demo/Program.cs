using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;
namespace _Cosumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathssss math = new Mathssss();
           
            Console.WriteLine("RESULT ADD : " + math.Add(10, 20));
            Console.WriteLine("RESULT SUB : " + math.Subtract(40,20));
            
            Console.ReadLine();
        }
    }
}
