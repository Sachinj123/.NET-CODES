using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _0DemoLinqStarted
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 10, 22,30,40,50,60 };

            Console.WriteLine("The AVG of Array is :"+arr.Average());

            //THE (arr.Avg),(arr.Max),(arr.Min),(arr.Sum) method is Presented in "System.Linq"
            //THESE ARE THE ------> "EXTENSION METHODS"

            Console.WriteLine("Total Sum of the Array:"+arr.Sum());

            Console.WriteLine("The Largest element in Array is:"+arr.Max());

            Console.WriteLine("The Smallest element in Array is:" + arr.Min());

            Console.ReadLine();
        }
    }
}
