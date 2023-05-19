using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _1DemoLAMBDAExpression
{
    // public delegate int MyDelegate (int a,int b);
    //NORMAL DELEGATE

    //public delegate Q MyDelegate<Q, T,R>(T t,R r); 
   //GENERIC DELEGATE DECLN

    // ----> GENERIC DELEGATE
    // Q ----> RETURN TYPE   T ------> VARIABLE
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GENERIC DELEGATE
            //GENERIC DELEGATE TAKE -----> 698 UNITS

            // MyDelegate<int,int,int> pointer = new MyDelegate<int, int, int>(Add); 

            //Q ----> ADD METHOD RETURN TYPE IS INT
            //X,Y ----> VARIABLE ARE INT TYPE


            //the above code is GENERIC DELEGATE 
            #endregion


            #region GENERIC DELEGATE WITH ANONYMOUS METHOD
            //THIS IS GENERIC DELEGATE WITH "ANONYMOUS METHOD" -----> 610 UNITS WITH ANONMYOUS METHOD
            // MyDelegate<int, int, int> pointer = delegate (int x, int y)
            //  {
            //    return x + y;
            //}; 
            #endregion



            #region NORMAL DELAGATE
            // MyDelegate pointer = new MyDelegate(Add);------>602 unit it takes
            //With the use of "Delegate it takes ----> 602 umits 
            #endregion


            //ACTION AND FUNC ARE THE 2 GENERIC DELEGATE 
            //PROVIDED BY .NET

            //but ACTION DELEGATE TAKES 16 INPUT PARAMETERS
            //AND RETURNS NOTHING

            //WHERE AS FUNC TAKES 17 PARAMETERS FROM THAT 17
            //16 INPUT PARAMETERS AND 1 OUTPUT PARAMETER

            // takes 978 units to exexute the FUNC DELEGATE

            #region FUNC DELEGATE WITH ANONYMOUS METHOD

            /*Func<int, int, int> pointer = delegate (int x, int y)
                                                    {
                                                        return x + y;
                                                    }; */
            #endregion


            #region FUNC DELEGATE WITH LAMBDA EXPRESSION

            Func<int, int, int> pointer = (x, y) =>
                                               {
                                                   return x + y;
                                               };  
            #endregion

            Stopwatch watch = new Stopwatch();

                 watch.Start();

            #region NORMAL WAY
            // It Takes 656 units  "NORMALLY"
            //int result = Add(10, 20); 
            #endregion

            
            int result = pointer(50, 20);
            watch.Stop();


            Console.WriteLine("Total Time Taken to Execute the Method is:"+watch.ElapsedTicks.ToString());
            Console.WriteLine("The Result is:"+result);

            Console.ReadLine();
        }

        // public static int Add(int x, int y)
        //{
        //   return x + y;
        //}

         
    }
}
