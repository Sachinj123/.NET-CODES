using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventsDELEGATES
{
    //Code Written by Sampada 
    //Sampada has purchased DLL written by Sachin
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLServer sql = new SQLServer();

            mydelegate pointer1 = new mydelegate(OnInsertCallMe);
            mydelegate pointer2 = new mydelegate(OnUpdateCallMe);
            mydelegate pointer3 = new mydelegate(OnDeleteCallMe);

            sql.Inserted += pointer1;
            sql.Updated += pointer2;
            sql.Deleted += pointer3;
            
            // += is the "Attachment" is used it is a special syntax  
            
            sql.Insert("Sachin PDF");
            sql.Update(".NET PDF");
            sql.Delete("HTML PDF");
            Console.ReadLine();
        }
        

        public static void OnInsertCallMe()
        {
            Console.WriteLine("Logging Insert into Console");

        }

        public static void OnUpdateCallMe()
        {
            Console.WriteLine("Logging Update into Console");

        }

        public static void OnDeleteCallMe()
        {
            Console.WriteLine("Logging Delete into Console");
           
        }
        
    }
    
    
}


namespace DB
{
    public delegate void mydelegate();

    //Written by SACHIN
    //Assume - logic is compiled into DLL and sold to various companies

    public class SQLServer
    {
        public event mydelegate Inserted;
        public event mydelegate Updated;
        public event mydelegate Deleted;

        public void Insert(string data)
        {
            Console.WriteLine(data + " Inserted into SQL Server");
            //Raise Event just like raise trigger in database  
            Inserted();
            Console.WriteLine("Logger Integrated logging details : Insert Successfull");
        }

        public void Update(string data)
        {
            Console.WriteLine(data + " Updated into SQL Server");
            //Raise Event just like raise trigger in database 
            Updated();
            Console.WriteLine("Logger Integrated logging details : Update Successfull");

        }

        public void Delete(string data)
        {
            Console.WriteLine(data + " Deleted into SQL Server");
            //Raise Event just like raise trigger in database 
            Deleted();
            Console.WriteLine("Logger Integrated logging details : Delete Successfull");
        }
    }
}