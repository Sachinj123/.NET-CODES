using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2DemoFuncWithLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WITH THE USE OF EXPRESSION TREE CREATE AND COMPILE IT TAKES ONLY "5" UNITS
            
            //STEP 1 - CREATE A EXPRESSION TREE
            Expression < Func<int, int, int>> tree = (x, y) => ( x + y);


            // STEP 2 - COMPILE THE EXPRESSION TREE
            Func<int, int, int> pointer = tree.Compile();

            Stopwatch watch = new Stopwatch();

            watch.Start();


            //STEP 3 - BELOW CODE
            int result = pointer(50, 20);
            watch.Stop();


            Console.WriteLine("Total Time Taken to Execute the Method is:" + watch.ElapsedTicks.ToString());
            Console.WriteLine("The Result is:" + result);

            Console.ReadLine();
        }
    }
}
