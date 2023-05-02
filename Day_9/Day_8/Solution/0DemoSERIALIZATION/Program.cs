using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


//THIS PROGRAM IS THE EXAMPLE OF SERIALIZATION(BINARY)
namespace _0DemoSERIALIZATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BINARY SERIALIZATION
            /* Emp emp = new Emp();
             Console.WriteLine("Enter No : ");
             emp.No = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Name : ");
             emp.Name = Console.ReadLine();

             string s = emp.getDetails();
             Console.WriteLine(s);

             FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Sampuzz.txt"
                     , FileMode.OpenOrCreate, FileAccess.Write);

             BinaryFormatter specialWriter = new BinaryFormatter();

             //STREAMWRITER is not capable for writing the data on HARD DRIVE
             specialWriter.Serialize(fs, emp);
             //fs,emp ---> where to write and what to write
             //specialWriter = null;
             // "WRITER" CLASS IS NOT SUITABLE FOR TAKE DATA FROM USER
             // THIS CLASS IS SUITABLE FOR THE DATA TYPES LIEK (INT,FLOAT,SHORT.......)
             fs.Flush();

             fs.Close();*/
            #endregion




            #region DeSERIALIZATION

            FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Sampuzz.txt"
                    , FileMode.Open, FileAccess.Read);

            BinaryFormatter specialReader = new BinaryFormatter();


            object obj = specialReader.Deserialize(fs);

            if (obj is Emp)
            {
                Emp e = (Emp)obj;
                Console.WriteLine(e.getDetails());

            }
            else
            {
                Console.WriteLine("UNKNOWN TYPE:");
            }


            fs.Flush();

            fs.Close(); 
            #endregion

            Console.ReadLine();
        }
    }
}

    [Serializable]
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
            return this._No.ToString() + " " + this._Name.ToString();
        }


    }

