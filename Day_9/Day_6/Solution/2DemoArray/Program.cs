using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DemoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayDemo1
            //int[] arr = new int[3];
            //arr[0] = 11;
            //arr[1] = 202;
            //arr[2] = 215;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //  Console.WriteLine(arr[i]);


            //}
            #endregion

            #region ArrayDemo2
            //  int[] arr2 = new int[] {100,200,300,400,500,600,700};
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //  Console.WriteLine(arr2[i]);
            //}
            #endregion

            Emp e1 = new Emp();
            e1.No = 1;
            e1.Name = "SAMPUZZ";

            Emp e2 = new Emp();
            e2.No = 2;
            e2.Name = "SACHIN";

            Emp e3 = new Emp();
            e3.No = 3;
            e3.Name = "Vishal";

            Emp[] employees = new Emp[3];
            employees[0] = e1;
            employees[1] = e2;
            employees[2] = e3;

            for (int i = 0; i < employees.Length; i++)
            {
                Emp e = employees[i];
                Console.WriteLine(e.getDetails());

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
