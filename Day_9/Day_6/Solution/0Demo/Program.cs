using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            object obj = i;

            obj = "abcd";
            //LAST STATEMENT OBJ HOLDS STRING THEREFORE THE OUTPUT IS 'ABCD"
            if(obj is int)
            {
                int j = Convert.ToInt32(obj);
                Console.WriteLine(j);

            }
            if(obj is string)
            {
                string s = Convert.ToString(obj);
                Console.WriteLine(s);
            }
           
            Console.ReadLine();
        }
    }
}
