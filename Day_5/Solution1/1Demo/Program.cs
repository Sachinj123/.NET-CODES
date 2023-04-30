using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// USE OF REGION HERE 
namespace _1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion BELOW IS THE WAY TO CALL THE GETTER AND SETTER IN C++

            Console.WriteLine("NORMAL OUTPUT ON THE OBJECT:");
            Person person = new Person();
            person.Set_Name("Sampuzzzz");
            person.Set_Age(23);

            string nm = person.Get_Name();
            int ag = person.Get_Age();

            Console.WriteLine("Name: " + nm);
            Console.WriteLine("AGE: " + ag);

            Console.WriteLine("OUTPUT WITH THE USE OF GETDETAILS:");
            Person p = new Person("SACHIN", 25);

            Console.WriteLine(p.GetDetails());

            Console.ReadLine();
            #endregion
        }
    }

    public class Person
    {
        

        #region  PRIVATE MEMBERS
        private string _Name;
        private int _Age;
        #endregion


        #region CONSTRUCTORS 

        //PARAMETERLESS CONSTRUCTOR
        public Person()
        {
            this._Name = " ";
            this._Age = 0;
        }

        //PARAMETARISED CONSTRUCTOR
        public Person(string name, int age)
        {

            this.Set_Name(name);
            this.Set_Age(age);

        }
        #endregion

        #region GETTER AND SETTERS

        public void Set_Name(String name)
        {
            if (name != "")
            {
                this._Name = name;
            }
            else
            {
                this._Name = "No Data";
            }
        }

        public void Set_Age(int age)
        {
            this._Age = age;
        }

        public string Get_Name()
        {
            return "Mr / Mrs  " + this._Name;
        }

        public int Get_Age()
        {
            return this._Age;
        }
        #endregion

        #region MEMBER FUNCTION
        public string GetDetails()
        {
            return "Welcome " + this.Get_Name() + " with AGE " + this.Get_Age().ToString();

        }
        #endregion




    }
}
