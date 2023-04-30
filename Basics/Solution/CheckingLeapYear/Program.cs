using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year to Check for Leap Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0 || year % 100 ==0 || year % 400 ==0 )
            {
                Console.WriteLine("The Entered Year is a Leap Year");

            }
            else
            {
                Console.WriteLine("The Entered Year is not a Leap Year");
            }
            Console.ReadLine();
        }
    }
}
