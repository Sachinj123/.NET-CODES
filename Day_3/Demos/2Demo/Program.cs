using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Demo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Coice For Performe Operation:");
            Console.WriteLine("1:Add, 2:Sub, 3:Mul,4:Divide");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (choice)
            {
                case 1:
                    result = x + y;
                    break;
                case 2:
                    result = x - y;
                    break;
                case 3:
                    result = x * y;
                    break;
                case 4:
                    result = x / y;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break; 
            }
            Console.WriteLine("RESULT:" + result);
            Console.ReadLine();



        }
            
        }
    }

