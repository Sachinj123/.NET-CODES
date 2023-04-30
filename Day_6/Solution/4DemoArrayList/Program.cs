using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4DemoArrayList
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


            Customer cust1 = new Customer();
            cust1.CustNo = 101;
            cust1.CustName = "MGM";
            cust1.OrderDetails = "Chairs";

            Customer cust2 = new Customer();
            cust2.CustNo = 102;
            cust2.CustName = "CDAC KOCHI";
            cust2.OrderDetails = "LAPTOPS";

            ArrayList arr = new ArrayList();
            arr.Add(e1);
            arr.Add(e2);
            arr.Add(e3);
            arr.Add(cust1);
            arr.Add(cust2);
            arr.Add("SACHIN");
            arr.Add(10.2);

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] is Employee)
                {
                    Employee e = (Employee)arr[i];
                    Console.WriteLine(e.getEmployeeDetails());
                }

                if (arr[i] is Customer)
                {
                    Customer c = (Customer)arr[i];
                    Console.WriteLine(c.getCustomerDetails());
                }
                if (arr[i] is int)
                {
                    int k = Convert.ToInt32(arr[i]);
                    Console.WriteLine(k);
                }
                if (arr[i] is string)
                {
                    string s = Convert.ToString(arr[i]);
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Unknown Type Data");
                }

            }
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

    public class Customer
    {
        private int _CustNo;
        private string _CustName;
        private string _OrderDetails;



        public int CustNo
        {
            get { return _CustNo; }
            set { _CustNo = value; }
        }

        public string CustName
        {
            get { return _CustName; }
            set { _CustName = value; }
        }

        public string OrderDetails
        {
            get { return _OrderDetails; }
            set { _OrderDetails = value; }
        }
        public string getCustomerDetails()
        {
            return this.CustNo.ToString() + " " + this.CustName.ToString() + "  " + this.OrderDetails;
        }

    }
}
