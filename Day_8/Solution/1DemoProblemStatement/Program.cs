using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace _1DemoProblemStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //XML SERIALIZATION IS ONLY FOR "PUBLIC" MEMBERS

            #region BINARY SERIALIZATION
            /*Emp emp = new Emp();
            Console.WriteLine("Enter No : ");
            emp.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            emp.Name = Console.ReadLine();

            string s = emp.getDetails();
            Console.WriteLine(s);

            Book b = new Book();

            Console.WriteLine("Enter BookID: ");
            b.BookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Title: ");
            b.Title = Console.ReadLine();

            ArrayList arr = new ArrayList();
            arr.Add(emp);
            arr.Add(b);

            FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Sampuzz.txt"
                    , FileMode.OpenOrCreate,
                      FileAccess.Write);

            BinaryFormatter specialReader = new BinaryFormatter();

            specialReader.Serialize(fs, arr);
            fs.Flush();

            fs.Close(); */
            #endregion


            #region XML - SERIALIZATION
            /* Emp emp = new Emp();
            Console.WriteLine("Enter No : ");
            emp.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            emp.Name = Console.ReadLine();

            string s = emp.getDetails();
            Console.WriteLine(s);

            FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Sampuzz.xml"
                    , FileMode.OpenOrCreate,
                      FileAccess.Write);

            XmlSerializer specialWriter = new XmlSerializer(typeof(Emp));

            //STREAMWRITER is not capable for writing the data on HARD DRIVE
            specialWriter.Serialize(fs, emp);
            //fs,emp ---> where to write and what to write
            //specialWriter = null;
            // "WRITER" CLASS IS NOT SUITABLE FOR TAKE DATA FROM USER
            // THIS CLASS IS SUITABLE FOR THE DATA TYPES LIEK (INT,FLOAT,SHORT.......)
            fs.Flush();

            fs.Close(); */
            #endregion


            #region XML - DeSERIALIZATION

            /* FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Sampuzz.xml"
                    , FileMode.Open, FileAccess.Read);

            XmlSerializer specialReader = new XmlSerializer(typeof(Emp));


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

            fs.Close();*/
            #endregion


            #region SOAP SERIALIZATION
            /*
             Emp emp = new Emp();
             Console.WriteLine("Enter No : ");
             emp.No = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Name : ");
             emp.Name = Console.ReadLine();

             string s = emp.getDetails();
             Console.WriteLine(s);

             FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\SampuzzSOAP.xml"
                     , FileMode.OpenOrCreate, 
                       FileAccess.Write);

             SoapFormatter specialWriter = new SoapFormatter();

             //STREAMWRITER is not capable for writing the data on HARD DRIVE
             specialWriter.Serialize(fs, emp);
             //fs,emp ---> where to write and what to write
             //specialWriter = null;
             // "WRITER" CLASS IS NOT SUITABLE FOR TAKE DATA FROM USER
             // THIS CLASS IS SUITABLE FOR THE DATA TYPES LIEK (INT,FLOAT,SHORT.......)
             fs.Flush();

             fs.Close();*/
            #endregion

            #region SOAP DeSERIALIZATION

            FileStream fs = new FileStream("C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\SampuzzSOAP.xml"
                    , FileMode.Open, FileAccess.Read);

            SoapFormatter specialReader = new SoapFormatter();


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

[Serializable]
public class Book
{
    private int _BookId;
    private string _Title;

    

    public int BookId
    {
        get { return _BookId; }
        set { _BookId = value; }
    }

    

    public string Title
    {
        get { return _Title; }
        set { _Title = value; }
    }


}
