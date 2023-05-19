using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _1Demo
{
    internal class Program
    {
       

        static void Main(string[] args)
        {


            #region SELECT QUERY
            /* SqlConnection conn = new SqlConnection
                    ("Server = (LocalDB)\\MSSQLLocalDB; database = CDAC_DB; Integrated Security = true");
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from Emp",conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    string dataForPrinting = 
                        string.Format("{0} ----- {1} ---- {2}", 
                                     reader["No"],
                                     reader["Name"], 
                                     reader["Address"]);

                    Console.WriteLine(dataForPrinting);



                }

                conn.Close();
               */
            #endregion

            #region INSERT QUERY
            /*  SqlConnection conn = new SqlConnection
                        ("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = CDAC_DB; Integrated Security = True; Pooling = False");

            //THE ABOVE CONNECTION QUERY WE TAKE FROM PROPERTIES
            //RIGHT CLICK ON DATABASE ---> PROPERTIES 
            conn.Open();

            Console.WriteLine("Enter No: ");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            string queryTemplate = "insert into Emp values({0}, '{1}', '{2}')";
            string finalInsertQuery = string.Format(queryTemplate, no, name, address);

            SqlCommand cmd = new SqlCommand(finalInsertQuery, conn);

            int NoOfRowsAffected = cmd.ExecuteNonQuery();

            Console.WriteLine("No Of Rows Affected: " + NoOfRowsAffected.ToString());

            conn.Close();*/
            #endregion

            #region INSERT QUERY WITH TRY CATCH

            /*SqlConnection conn = null;

            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection
                       ("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = CDAC_DB; Integrated Security = True; Pooling = False");

                //THE ABOVE CONNECTION QUERY WE TAKE FROM PROPERTIES
                //RIGHT CLICK ON DATABASE ---> PROPERTIES 
                conn.Open();

                Console.WriteLine("Enter No: ");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Address: ");
                string address = Console.ReadLine();

                string queryTemplate = "insert into Emp values({0}, '{1}', '{2}')";
                string finalInsertQuery = string.Format(queryTemplate, no, name, address);

                cmd = new SqlCommand(finalInsertQuery, conn);

                int NoOfRowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine("No Of Rows Affected: " + NoOfRowsAffected.ToString());

            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went Wrong try again !!!");
                Console.WriteLine("Technical Details " + ex.Message);
            }

            finally
            {
                conn.Close();
            } 
            */
            #endregion


            #region UPDATE QUERY
            /*
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlConnection conn = new SqlConnection
                    ("Server = (LocalDB)\\MSSQLLocalDB; database = CDAC_DB; Integrated Security = true");
            conn.Open();

            string updateQuery = "Update Emp set Name = '" + " Hindavi" + "' where No=103";            

            SqlCommand cmd = new SqlCommand(updateQuery ,conn);

            adapter.UpdateCommand = new SqlCommand(updateQuery ,conn);

            int NoOfRowsAffected=  adapter.UpdateCommand.ExecuteNonQuery();
            Console.WriteLine("Number of Rows Updated :"+NoOfRowsAffected);

            cmd.Dispose();
            conn.Close();
            */
            #endregion

            #region Delete Query
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlConnection conn = new SqlConnection
                    ("Server = (LocalDB)\\MSSQLLocalDB; database = CDAC_DB; Integrated Security = true");
            conn.Open();

            string deleteQuery = "Delete Emp where No=103";

            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            adapter.DeleteCommand = new SqlCommand(deleteQuery, conn);

            

            int NoOfRowsAffected = adapter.DeleteCommand.ExecuteNonQuery();

            Console.WriteLine("Number of Rows Deleted :" + NoOfRowsAffected);

            cmd.Dispose();
            conn.Close();

            #endregion




            Console.ReadLine();
        }
    }
}
