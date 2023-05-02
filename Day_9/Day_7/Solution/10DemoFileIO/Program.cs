using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10DemoFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FileStream-1 FILE CREATION AND WRITING INTO FILE
            /*FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_7\\Solution\\Sachin.txt"
                    , FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Hello All !!");
            // NEW TXT FILE IS CREATED INTO DAY_7 FOLDER and into the file "HELLO ALL !!" IS WRITTEN
            //fs.Flush();  -----> THIS IS RESPOSNSIBLE FOR TRANSFER THE DATA FROM MEMORY INTO HARD DRIVE
            writer.Close();

            fs.Close(); */
            #endregion

            #region READING RECORDS FROM FILE 
            /*FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_7\\Solution\\Sachin.txt"
                       , FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);
            string entireData = reader.ReadToEnd();
            Console.WriteLine(entireData);
            // NEW TXT FILE IS CREATED INTO DAY_7 FOLDER and into the file "HELLO ALL !!" IS WRITTEN by writer.WriteLine();
            // StreamReader is used to read the data from the Sachin.txt file

            fs.Flush();

            //Flush-----> THIS IS RESPOSNSIBLE FOR TRANSFER THE DATA FROM MEMORY INTO HARD DRIVE
            reader.Close();

            fs.Close(); */
            #endregion


            Emp emp = new Emp();
            Console.WriteLine("Enter No : ");
            emp.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            emp.Name = Console.ReadLine();

            string s = emp.getDetails();
            Console.WriteLine(s);

            FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_7\\Solution\\Sampuzz.txt"
                    , FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine(emp); // "WRITER" CLASS IS NOT SUITABLE FOR TAKE DATA FROM USER
            // THIS CLASS IS SUITABLE FOR THE DATA TYPES LIEK (INT,FLOAT,SHORT.......)
            fs.Flush();
            writer.Close();
            fs.Close();
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
            return this._No.ToString()+" "+this._Name.ToString();
        }


    }
}
