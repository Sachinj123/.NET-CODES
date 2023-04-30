using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Demo_ArrayListProblemStatement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            while (true)
            {

                Console.WriteLine("Enter the Choice:");
                Console.WriteLine("1:Employee , 2:Book ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Employee emp = new Employee();

                    Console.WriteLine("Enter Employee Number");
                    emp.No = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Name of the Employee");
                    emp.Name = Console.ReadLine();

                    list.Add(emp);

                }
                else
                {
                    Book book = new Book();

                    Console.WriteLine("Add Book Title:");
                    book.Title = Console.ReadLine();

                    Console.WriteLine("Enter Author Name:");
                    book.Author = Console.ReadLine();

                    list.Add(book); 
                }

                Console.WriteLine("Would you like to continue? yes/no ");
                string continueorNot = Console.ReadLine();
                if (continueorNot != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Entered Data:");

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Employee)
                {
                    Employee emp = (Employee)list[i];
                    Console.WriteLine(emp.getEmployeeDetails());
                }

                else if (list[i] is Book)
                {
                    Book book = (Book)list[i];
                    Console.WriteLine(book.getBookDetails());
                }

            }
            Console.ReadLine();

        }

    }

    public class Employee
    {
        private int _No;
        private string _Name;



        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }


        
         public string getEmployeeDetails()
            {
                 return this.No.ToString() + " " + this.Name;
            }
        


    }

    public class Book
    {
        private string _Title;
        private string _Author;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string getBookDetails()
        {
            return this.Title +"  "+ this.Author;

        }

        
    }
}

