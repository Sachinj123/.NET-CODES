using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalciLib;

//On line number 6 we using the the DLL 
//we manually created the dll and add
//into the project

namespace _3Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();

            Console.WriteLine("Enter Coice For Performe Operation:");
            Console.WriteLine("1:Add, 2:Sub, 3:Mul,4:Div");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = 0;

           
            //UPDATED CODE OF THE PREVIOUS
            switch (choice)
            {
                case 1:
                    result = maths.Add(x,y);
                    break;
                case 2:
                    result = maths.Sub(x, y);
                    break;
                case 3:
                    result = maths.Mul(x, y);
                    break;
                case 4:
                    result = maths.Div(x,y);
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
