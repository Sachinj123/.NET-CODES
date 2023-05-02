using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DemoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface Database
    {
        void Insert();
        void Update();
        void Delete();

    }

    public class SQLServer:Database
    { 
        public void Insert()
        {
            Console.WriteLine("SQL Data is inserted");

        }
        public void Update() 
        {
            Console.WriteLine("SQL Data is Updated");
        }
        public void Delete() 
        {
            Console.WriteLine("SQL Data is Deleted");
        }
    }

    public class Oracle : Database
    {
        public void Insert()
        {
            Console.WriteLine("Oracle Data is inserted");

        }
        public void Update()
        {
            Console.WriteLine("Oracle Data is Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Data is Deleted");
        }
    }


}
