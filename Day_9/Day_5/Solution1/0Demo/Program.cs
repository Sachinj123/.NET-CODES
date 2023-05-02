using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("NORMAL OUTPUT ON THE OBJECT:");
            Person person = new Person();
            person.Set_Name("Sampuzzzz");
            person.Set_Age(23);

            string nm = person.Get_Name();
            int ag = person.Get_Age();

            Console.WriteLine("Name: "+nm);
            Console.WriteLine("AGE: "+ag);

            Console.WriteLine("OUTPUT WITH THE USE OF GETDETAILS:");
            Person p = new Person("SACHIN", 25);
            
            Console.WriteLine(p.GetDetails());

            Console.ReadLine();
        }

        
        
    }

    public class Person
    {
        //PARAMETERLESS CONSTRUCTOR
        public Person()
        {
            this._Name = " ";
            this._Age = 0;
        }
        private string _Name;
        private int _Age;

        //PARAMETARISED CONSTRUCTOR
        public Person(string name,int age)
        {

            this.Set_Name(name);
            this.Set_Age(age);

        }
        ///<summary>
        ///This function helps you to set up the NAME AND AGE of the Person
        ///You can try setting the name using : personObject.Set_Name("sachin)
        ///</summary>
        ///<param name="name">This is the name of the Person</param>
        ///
         
        public void Set_Name(String name)
        {
            if(name != "")
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

        public string GetDetails()
        {
            return "Welcome " + this.Get_Name() + " with AGE " + this.Get_Age().ToString();

        }

    }


}
