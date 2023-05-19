using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Demo_NAMED_AND_OPTIONAL_PARAMETER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //IF I AM DIDNT PASS "NAME = SACHIN" THEN IT IS BY DEFAULT TAKES "ABCB" FROM LINE NO 31 SAME AS ADDRESS

            String details1 =  student.GetDetailsOfStudent(10, "SACHIN");

            String details2 = student.GetDetailsOfStudent(10, "SACHIN");

            String details = student.GetDetailsOfStudent(10, Address:"Kolkata",Name:"Nitin");
            //THE Syntax on Line no 19 is known as "NAMED PARAMETER"
            //in details2 name is considered as a Kolkata because we pass after 10 then the solution is on line no 19

            Console.WriteLine(details);

            //The Required parameter is always declared on the left side like 10

            Console.ReadLine();
        }
       
    }

    public class Student
    {
        /* public string GetDetailsOfStudent(int Id,string Name,string Address)
         {
             return string.Format("Details are: No is {0}. Your name is {1} and Address is {2}",Id,Name,Address);

         }*/

        public string GetDetailsOfStudent(int Id, string Name="ABCD", string Address="Mumbai")
            //----> This syntax is known as Optional parameter
        {
            return string.Format("Details are: No is {0}. Your name is {1} and Address is {2}", Id, Name, Address);

        }
    }
}
