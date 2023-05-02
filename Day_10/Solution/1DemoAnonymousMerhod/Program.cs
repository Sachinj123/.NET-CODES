using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DemoAnonymousMerhod
{
    internal class Program
    { 
        delegate string myDelegate(string name);
        static void Main(string[] args)
        {
            #region NORMAL METHOD CALLING

            //NORMAL METHOD CALLING - 1
            //string message = SayHi("Sachin");
            //Console.WriteLine(message);

            //NORMAL METHOD CALLING WITH THE USE OF DELEGATE

            /* myDelegate pointer = new myDelegate(SayHi);
            string message = pointer("Sachin");
            Console.WriteLine(message); */
            #endregion


            #region AnonymousMethod

            myDelegate pointer = delegate (string name) //----> THIS IS THE Decln OF Anonymous Method 
           {
               return "Hello " + name;
           };
            string message = pointer("Sachin");
            Console.WriteLine(message);


            Console.ReadLine(); 
            #endregion


        }


        #region NORMAL METHOD DECLARATION
        //NORMAL METHOD DECLARATION
        //    public static string SayHi(string name)
        //    {
        //      return "Hello " + name;
        //    } 
        #endregion
    }
}
