using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6DemoHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.No = 1;
            e1.Name = "SACHIN";
            e1.DeptName = "DEVELOPER";

            Employee e2 = new Employee();
            e2.No = 2;
            e2.Name = "SAMPUZZZZ";
            e2.DeptName = "Front-End Developer";

            Employee e3 = new Employee();
            e3.No = 3;
            e3.Name = "VISHAL";
            e3.DeptName = "HEAD";

            Hashtable arr = new Hashtable();
            arr.Add("1", e1);
            arr.Add("2", e2);
            arr.Add("3", e3);

            //HASHTABLE USES KEY VALUE PAIR FORMAT KEY CAN BE UNIQUE
            //BUT VALUES CAN BE SAME OR NULL 
            //KEY ----> ALPHABATES,NUMBERS

            //BUT ALWAYS REMEMBER MAKE KEYS CAN BE ONE TYPE
            //EITHER NUMERIC OR ALPHABATIC

            arr.Add("101", "abcd");
            arr.Add("102", "SACHIN");
            arr.Add("A", 10.2);

            //THIS IS THE SEARCHING OF THE ELEMENTS FROM HASHTABLE
            //BASED ON THE KEYS

            //Console.WriteLine("What would you like to Search please enter:");
            //string key = Console.ReadLine();


            foreach (object key in arr.Keys)  //------------>THIS IS USED TO PRINT ONLY KEYS OF HASHTABLE
            {
                Console.WriteLine(key);
                object obj = arr[key];

                if (obj is Employee)
                {
                    Employee e = (Employee)obj;
                    Console.WriteLine(e.getEmployeeDetails());
                }


                if (obj is int)
                {
                    int k = Convert.ToInt32(obj);
                    Console.WriteLine(k);
                }
                if (obj is string)
                {
                    string s = Convert.ToString(obj);
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Unknown Type Data");
                }

                //}
                Console.ReadLine();

            }
        }

        public class Employee
        {
            private int _No;
            private string _Name;
            private string _DeptName;


            public int No
            {
                get { return _No; }
                set { _No = value; }
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public string DeptName
            {
                get { return _DeptName; }
                set { _DeptName = value; }
            }

            public string getEmployeeDetails()
            {
                return this.No.ToString() + " " + this.Name.ToString() + " " + this.DeptName;
            }

        }
    }
}
