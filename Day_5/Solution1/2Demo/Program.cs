using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Demo
{
    internal class Program
    {
        static void Main( string[] args)
        {

            //Person person = new Person();
            //person.Age = 24;
            //person.Name = "SAMPUZZZ";
            //1st OUTPUT WITH THE HELP OF NORMAL FUNCTION
            //Console.WriteLine("AGE "+person.Age);
            //Console.WriteLine("NAME: "+person.Name);
            // 2ND FUNCTION WITH THE HELP OF METHOD
            //Console.WriteLine(person.GetDetails());
            //Console.ReadLine();

            Employee emp = new Employee();
            emp.Name = "Sampuzzzz";
            emp.Age = 24;
            emp.DName = "IT";

            string details = emp.GetDetails();
            Console.WriteLine(details);
            Console.ReadLine();
        }
    }

    public class Person
    {
        private string _Name;
        private int _Age;
       
        //PARAMETERLESS CONSTRUCTOR
        public Person()
        {
            this.Name = " ";
            //this.Name he (=) equals chya left side la ahe tr SETTER CALL HONAR
            //this.Name he (=) equals chya right side la asel tr GETTER CALL HONAR
            this.Age = 0;
        }

        //PARAMETARISED CONSTRUCTOR
        public Person(string name, int age)
        {

            this.Age = age;
            this.Name = name;

        }

       
        public string Name
        {
            get
            {
                return " MR / MRS " + this._Name;

            }
            set
            {
                if (value != " ")
                {
                    this._Name = value;
                }
                else
                {
                    this._Name = "NO DATA";
                }
            }
        }

        public int Age
        {
            get
            {
                return this._Age;


            }
            set
            {
                this._Age = value;

            }
        }

        public virtual string  GetDetails()
        {
            return "Welcome " + this.Name + " with AGE " + this.Age.ToString();

        }



    }
    
    
    //use "propfull" and press 2 times tab then IDE automatically generate 
    // getter and setter directly
    public class Employee : Person
    {
        private string _DName;

        public string DName
        {
            get { return _DName; }
            set { _DName = value; }
        }

        public override string GetDetails()
        {
           return base.GetDetails() + " From Department " +this.DName;
            //the above "GetDetails" method is from person class
        }


    }
}
