using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


//ALL THE DATA STORED IN MEMORY NOT IN DATABASE

namespace _4Demo_Disconnected_Architecture
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region DATA TABLE CONCEPT
            /*
            DataTable table = new DataTable("Table1");

            DataColumn column1 = new DataColumn("No", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Address", typeof(string));

            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);

            table.PrimaryKey = new DataColumn[] { column1 };

            DataRow r1 = table.NewRow();
            r1["No"] = 1;
            r1["Name"] = "Sachin";
            r1["Address"] = "Nanded";

            DataRow r2 = table.NewRow();
            r2["No"] = 2;
            r2["Name"] = "Sampuzz";
            r2["Address"] = "Pune";

            DataRow r3 = table.NewRow();
            r3["No"] = 3;
            r3["Name"] = "Nitin";
            r3["Address"] = "Mukhed";

            table.Rows.Add(r1);
            table.Rows.Add(r2);
            table.Rows.Add(r3); 
            */
            #endregion

            DataSet ds = new DataSet();

            //DATA SET IS THE COLLECTION OF TABLES

            DataTable table = new DataTable("Table2");

            DataColumn column1 = new DataColumn("No", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Address", typeof(string));

            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);
            //here we apply primary key

            table.PrimaryKey = new DataColumn[] { column1 };


            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CDAC_DB;Integrated Security=True;Pooling=False");

            SqlCommand cmd = new SqlCommand("Select * from Emp", conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                DataRow r = table.NewRow();
                r["No"] = Convert.ToInt32(reader["No"]);
                r["Name"] = reader["Name"].ToString();
                r["Address"] = reader["Address"].ToString();

                table.Rows.Add(r);
            }

            conn.Close();

//---------------------------------------------------------------------->>
            ds.Tables.Add(table);
            //This table data is from SQL Server
//---------------------------------------------------------------------->>

            DataRow completeNewRow = ds.Tables[0].NewRow();
            completeNewRow["No"] = 6;
            completeNewRow["Name"] = "Pavan";
            completeNewRow["Address"] = "Hingoli";

            ds.Tables[0].Rows.Add(completeNewRow);


            //SECOND TABLE

            DataTable t2 = new DataTable("Book");
            DataColumn c1 = new DataColumn("ISBN", typeof(int));
            DataColumn c2 = new DataColumn("Title", typeof(string));

            t2.Columns.Add(c1);
            t2.Columns.Add(c2);

            DataRow r1 = t2.NewRow();
            r1["ISBN"] = 1025;
            r1["Title"] = "Core Java";

            t2.Rows.Add(r1);

//---------------------------------------------------------------------->>
            ds.Tables.Add(t2);
            //This table data is from in memory
//---------------------------------------------------------------------->>

            //Line no 126 and 94 here we added the the 2 tables into " dataset"


            
            Console.ReadLine();
        }


    }
}
