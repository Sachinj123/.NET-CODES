using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _5Demo_Data_AdapterUSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new 
                SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CDAC_DB;Integrated Security=True;Pooling=False");

            SqlDataAdapter da = new SqlDataAdapter("Select * from Emp", conn);

            
            //the below line is acts as a primary key
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            
            //Coomand Builder is respornsible for automatic creating "Insert,Update,delete" Query
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);

            //THE BELOW LINE DOES EVERYTHING LIKE OPENING AND CLOSING THE CONNECTION
            ////FETCH THE DATA FROM DATABASE ALL THINGS
            da.Fill(ds, "Emp");


            #region INSERTION USING DISCONNECTED ARCHITECTURE
            /*
            DataRow completeNewRow = ds.Tables["Emp"].NewRow();
            completeNewRow["No"] = 6;
            completeNewRow["Name"] = "Pavan";
            completeNewRow["Address"] = "Hingoli";

            ds.Tables[0].Rows.Add(completeNewRow); 
            */
            #endregion

            #region UPDATE A ROW USING DISCONNECTED ARCHITECTURE
            /*
            Console.WriteLine("Enter a No as a Emp whose record you wish to find:");
            int no = Convert.ToInt32(Console.ReadLine());

            DataRow TheRowToBeModified = ds.Tables[0].Rows.Find(no);

            if(TheRowToBeModified != null )
            {
                Console.WriteLine("Record Found:");

                Console.WriteLine("No :" + TheRowToBeModified["No"].ToString());
                Console.WriteLine("Name :" + TheRowToBeModified["Name"].ToString());
                Console.WriteLine("Address is :" + TheRowToBeModified["Address"].ToString());

                Console.WriteLine("---------------------------------------------------------");

                Console.WriteLine("Please Enter New Name");
                TheRowToBeModified["Name"] = Console.ReadLine();

                Console.WriteLine("Please Enter New Address");
                TheRowToBeModified["Address"] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry No Record Found:");
            }
            */
            #endregion

            #region DELETE USING DISCONNECTED ARCHITECTURE

            Console.WriteLine("Enter a No of a Emp whose record you wish to Deleted:");
            int no = Convert.ToInt32(Console.ReadLine());

            DataRow TheRowToBeDeleted = ds.Tables[0].Rows.Find(no);

            if (TheRowToBeDeleted != null)
            {
                Console.WriteLine("Record Found ...Deleting the Same:");
                TheRowToBeDeleted.Delete();

            }
            else
            {
                Console.WriteLine("Sorry No Record Found:");
            }
            #endregion

            da.Update(ds,"Emp");
           Console.ReadLine();
        }
    }
}
