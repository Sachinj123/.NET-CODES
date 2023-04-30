using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Emp e = new Emp();
            e.No = 10;
            e.Name = "SACHIN";

            //int i = 100;
            object obj = e;

            //obj = "abcd";
            //LAST STATEMENT OBJ HOLDS STRING THEREFORE THE OUTPUT IS 'ABCD"
            if (obj is int)
            {
                int j = Convert.ToInt32(obj);
                Console.WriteLine(j);

            }
            else if (obj is string)
            {
                string s = Convert.ToString(obj);
                Console.WriteLine(s);
            }

            else if (obj is Emp)
            {
                Emp e1 = (Emp) obj;
                Console.WriteLine(e1.getDetails());
            }

            Console.ReadLine();
        }
    }

    public class Emp
    {
        private int _No;
        private string _Name;

        

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

        public string getDetails()
        {
            return this.No.ToString() + this.Name;
        }

    }
}
