using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace _1Demo_NewSyntaxForGetterandSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Anonymous Type
            //Emp e = new Emp();
            //NORMAL WAY OR SYNTAX TO SET THE VALUES FOR VARIABLES

            /*e.id = 1;
            e.Name = "SACHIN";
            e.Salary = 35000;
            e.Age = 26;*/

            //Object Initializer Block or Syntax (when emp class uncommented)


            // var e1 = new Emp() { id=1, Name="SACHIN",Salary=35000,Age=26}; 
            //-------> THIS IS THE SHORTER WAY TO SET THE VALUES 


            //HERE COMPILER AUTOMATICALLY GENERATE CLASS 
            //we commented the whole class
            //THE CLASS NAME WE CAN SEE IN MSIL CODE 
            //WITH THE HELP OF "ILDASM"

            //Jar right hand side la kaay ahe he mahiti nasel tr 
            // "VAR" use karaycha

            //var e = new { id = 1, Name = "SACHIN", Salary = 35000, Age = 26 };

            //THE ABOVE and BELOW CODE DONT GENERATE THE SETTER
            //ON LEFT HAND SIDE WE CREATE AN OBJECT OF Anonymous Type

            //var e1 = new { id = 2, Name = "SAMPUZZZ", Salary = 45000, Age = 24 };// ---> HERE DOESNT CREATE THE 2nd Class
            //Because the order is same of the variable
            // name = 1234 take doesnt create any problem here


            //var e2 = new { id = 3, Salary = 85000, Name = "Vishal", Age = 31 };// ---> HERE CREATE THE 2ND CLASS
            // BECAUSE THE ORDER OF THE VARIABLE IS CHANGED check in MSIL CODE -----> :"ILDASM"
            // Console.WriteLine(e.id + " " + e.Name + " " + e.Salary + " " + e.Age);

            #endregion

            //STRING IS A "SEALED CLASS"
            Console.ReadLine();
        }
    }

    /* public class Emp
     {
         //THIS IS THE SHORTER WAY TO DECLARE THE GETTER AND SETTER
         // USE -----> "prop" and press 2 times tab

         // THESE ARE THE GETTER AND SETTERS ARE DECLARED
         // AND C# COMPILER AUTOMATIC GENERATE PRIVATE VARIABLE OF EMP CLASS

         // LIKE private id,name,salary

         // jar aplyala getter and setter la manipulation karaycha
         //nasel tr ha syntax use karaycha

         //With the use of this syntax we just set and get the values

         //NORMAL WAY TO DECLARE THE SYNTAX OF GETTER AND SETTER
         //HERE WE MANUALLY WRITE THE PRIVATE VARIABLE (_AGE)
         private int _Age;

         public int Age
         {
             get { return _Age; }
             set { _Age = value; }
         }

         //SHORTER SYNTAX
         public int id { get; set; }

         public string Name { get; set; }

         public float Salary { get; set; }

     }*/
}
