using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6DemoGenericClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region METHOD CALLING ON NORMAL CLASS "SPECIALMATHS"
            /*SpecialMaths sp = new SpecialMaths();

            double p1 = 10.55;
            double q1 = 20.12;

            Console.WriteLine("BEFORE SWAPPING p1= " + p1.ToString() + "and q1 =" + q1.ToString());
            sp.Swap(ref p1, ref q1);
            Console.WriteLine("AFTER SWAPPING p1= " + p1.ToString() + "and q1 =" + q1.ToString()); */
            #endregion

            #region METHOD OF CALLING GENERIC SUB CLASS 
            SpecialMaths<int, double, short, string> sp =
                    new SpecialMaths<int, double, short, string>();

            string data = sp.DoSomething(100, 10.2, 2, "SACHIN");
            Console.WriteLine(data);

            #endregion

            Console.ReadLine();
        }
    }

    #region GENERIC CLASS 
    /*public class Maths<T>
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

    //GENERIC CLASS INHERITANCE


    #region Normal class is inherites from generic class 
    /* public class SpecialMaths : Maths<double> //<double> provide is mandatory here
     {

     }*/
    #endregion

    #region SUPERCLASS GENERICS
    public class Maths<T>
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
    }
    #endregion

    //NOW SUB CLASS IS ALSO GENERIC CLASS HERE
    #region GENERICS SUBCLASS
    public class SpecialMaths<P, Q, R, S> : Maths<S>
    {
        public S DoSomething(P p, Q q, R r, S s)
        {
            return s;

        }
    } 
    #endregion


}
