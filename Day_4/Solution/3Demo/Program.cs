using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice:");
            Console.WriteLine("1:MySQL, 2:ORACLE");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1:INSERT, 2:DELETE, 3:UPDATE");
            int opChoice = Convert.ToInt32(Console.ReadLine());

            ObjectFactory objFactory = new ObjectFactory();

            Database db = objFactory.GetMeSomeObject(choice);
            switch(opChoice)
            {
                case 1:
                    db.Insert();
                   break;

                case 2:
                    db.Delete();
                  
                    break;
                case 3:
                    db.Update(); 
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
        }
    }

    public class ObjectFactory
    {
        public Database GetMeSomeObject(int choice)
        {
            if(choice == 1)
            {
                return new MySQL();
            }
            else
            {
                return new Oracle();
            }
        }
    }
    public abstract class Database
    {
        public abstract void Insert();

        public abstract void Delete();

        public abstract void Update();

       
    }

    public class MySQL : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Data is DELETED from MySQL DATABASE");
        }

        public override void Insert()
        {
            Console.WriteLine("Data is INSERTED in MySQL DATABASE");
        }

        public override void Update()
        {
            Console.WriteLine("Data is UPDATED in MySQL DATABASE");
        }
    }

    public class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Data is DELETED from ORACLE DATABASE");
        }

        public override void Insert()
        {
            Console.WriteLine("Data is INSERTED in ORACLE DATABASE");
        }

        public override void Update()
        {
            Console.WriteLine("Data is UPDATED in ORACLE DATABASE");
        }
    }
}
