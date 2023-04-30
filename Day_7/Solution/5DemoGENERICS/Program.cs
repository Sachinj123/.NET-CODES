using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DemoGENERICS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region GENERIC METHOD SWAP OF(INT AND DOUBLE)

            /* Maths<int> math = new Maths<int>();

             int p = 10;
             int q = 20;

             Console.WriteLine("BEFORE SWAPPING p= " + p.ToString() + "and q =" + q.ToString());
             math.Swap(ref p, ref q);
             Console.WriteLine("AFTER SWAPPING p= " + p.ToString() + "and q =" + q.ToString());


             Maths<double> math2 = new Maths<double>();

             double p1 = 10.55;
             double q1 = 20.12;

             Console.WriteLine("BEFORE SWAPPING p1= " + p1.ToString() + "and q1 =" + q1.ToString());
             math2.Swap(ref p1, ref q1);
             Console.WriteLine("AFTER SWAPPING p1= " + p1.ToString() + "and q1 =" + q1.ToString());
            */
            #endregion

            Maths math = new Maths();
            int result = math.Add(10, 20);
            Console.WriteLine("RESULT:"+result);

            int p = 10;
            int q = 20;

            Console.WriteLine("BEFORE SWAPPING p= " + p.ToString() + "and q =" + q.ToString());
            math.Swap<int>(ref p, ref q);
            Console.WriteLine("AFTER SWAPPING p= " + p.ToString() + "and q =" + q.ToString());


            Console.ReadLine();
        }
    }

    #region GENERIC CLASS DECLARATION

    /* public class Maths<T>
    {
        public int Add(ref int x, ref int y)
        {
            return x + y;
        }

        public void Swap(ref T x, ref T y)
        {
            T z;
            z = x;
            x = y;
            y = z;

        }


    }*/
    #endregion


    #region NORMAL CLASS WITH GENERIC METHOD

    public class Maths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        //HERE WE DECLARE THE METHOD AS ----> "GENERIC METHOD"
        public void Swap<T>(ref T x, ref T y)
        {
            T z;
            z = x;
            x = y;
            y = z;

        }
        #endregion



    }
}
