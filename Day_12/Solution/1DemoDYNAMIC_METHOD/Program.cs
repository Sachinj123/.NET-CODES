using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DemoDYNAMIC_METHOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Console.WriteLine("Enter Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            /*object obj =  factory.GetMeSomeTypeObject(choice);

            if(obj is Employee)
            {
                Employee emp = (Employee)obj;
                Console.WriteLine(emp.GetDetails());
            }

            else if(obj is Book)
            {
                Book book = (Book)obj;
                Console.WriteLine(book.GetBookDetails());
            }*/

            //DYNAMIC OBJECT

            //"VAR" GETS DEFINATION AT COMPILE TIME & "DYNAMIC" GETS DEFINATION AT RUN TIME

            //DYNAMIC USES REFLECTION THEREFORE IT REDUCES THE PERFORMANCE

            dynamic obj = factory.GetMeSomeTypeObject(choice);
            Console.WriteLine(obj.GetDetails());

            //WE HARD CODED THE "GETDETAILS" METHOD
            //IT WILL ONLY RUN FOR THIS METHOD

            Console.ReadLine();

        }
    }

    public class Book
    {
        public string GetBookDetails()
        {
            return "Some Book Details....";
        }
    }

    public class Factory
    {
       public object GetMeSomeTypeObject(int choice)
        {
            if (choice == 1)
            {
                return new Employee();
            }
            else
            {
                return new Book();
            }
        }
    }
}
