using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DemoListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "SACHIN";
            s1.Age = 26;

            Student s2 = new Student();
            s2.Name = "SAMPUZZZ";
            s2.Age = 24;

            
            List <Student> list = new List<Student>();
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);

            for (int i = 0; i <list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            list.Add(s1);
            list.Add(s2);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(s1.getDetails());
                Console.WriteLine(s2.getDetails());

            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        private int _age;
        private string _name;

        

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string getDetails()
        {
            return this.Age+ "  " + this.Name.ToString();
        }

    }
}
