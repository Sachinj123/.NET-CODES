using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0DemoPARTIAL_METHOD
{
    internal class Program
    {

        //PARTIAL METHOD IS USEFUL WHEN HALF CODE IS PARTIALLY GENERATED CODE 
        //AND PARTIALLY DEVELOPER WRITTERN CODE  

        //PARTIAL METHODS ONLY DECLARD IN PARTIAL METHOD
        //THIS IS THE FIRST CRITERIA

        //PARTIAL METHODS ARE BY DEFAULT "PRIAVTE"
        //THEY CAN NOT BE CALL OUTSIDE OF THE CLASS

        //RETURN TYPE OF THE PARTIAL METHOD IS ALWAYS "VOID"

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Age = 26;


            Console.ReadLine();
        }
    }
}
