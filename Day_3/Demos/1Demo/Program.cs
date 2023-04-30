using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int result = Add();
            //PRESS F10 FOR MOVING TO NEXT LINE IN DEBUGGING
            //IN THE ABOVE CODE

            Console.WriteLine("Result:"+result);
            Console.ReadLine();

        }
        static int Add()
        {
            //First Program
            // WE TAKE THE INPUT FROM USER

            Console.WriteLine("Please Enter 1st Value:");      //---->>SYSO
            string s1 = Console.ReadLine();//----->> Scanner In Java


            Console.WriteLine("Please Enter 2nd Value:");
            string s2 = Console.ReadLine();

            //STRING TO INT CONVERSION
            int x = Convert.ToInt32(s1);

            int y = Convert.ToInt32(s2);
            int result = x + y;

            return result;
        }
    }
}
