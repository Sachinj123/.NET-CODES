using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _1Demo_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Configuration Managrer, SQL Injection
            /*
            string constr = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

            SqlConnection conn = new SqlConnection(constr);

            Console.WriteLine("Enter Name: ");

            // string cmdText = "Select * from Emp where Name = '" + Console.ReadLine() + "'";

            string cmdText = "Select count (*) from Emp where Name = '" + Console.ReadLine() + "'";
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();

            //SqlDataReader reader = cmd.ExecuteReader();

            //It is used when "select * from emp 
           // while (reader.Read())
           // {
             //   Console.WriteLine(string.Format("{0}, {1}, {2}", reader[0], reader[1], reader[2]));
            //}

            object result = cmd.ExecuteScalar();
            int count = Convert.ToInt32(result);

            if (count > 0)
            {
                Console.WriteLine("You are a Valid User ...");
            }
            else
            {
                Console.WriteLine("You are Invalid User...");
            }
            conn.Close(); */
            #endregion

            #region STORED PROCEDURE

            SqlConnection conn = null;
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

                 conn = new SqlConnection(constr);

                SqlCommand cmd = new SqlCommand("spInsert", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@No", SqlDbType.Int);
                Console.WriteLine("Enter No :");
                parameter1.Value = Convert.ToInt32(Console.ReadLine());

                SqlParameter parameter2 = new SqlParameter("@Name", SqlDbType.VarChar,20);
                Console.WriteLine("Enter Name :");
                parameter2.Value = Console.ReadLine();


                SqlParameter parameter3 = new SqlParameter("@Address", SqlDbType.VarChar,25);
                Console.WriteLine("Enter Address :");
                parameter3.Value = Console.ReadLine();

                cmd.Parameters.Add(parameter1);
                cmd.Parameters.Add(parameter2);
                cmd.Parameters.Add(parameter3);

                conn.Open();

                cmd.ExecuteNonQuery();

                

                Console.WriteLine("Record Inserted Successfully in the DB with the Use of Stored Procedure...");


            }
            catch (Exception ex)
            {

                Console.WriteLine("Record Inserted failed in the DB with the Use of Stored Procedure...");
                Console.WriteLine(ex.Message);
            }

            finally 
            {
                conn.Close();
            }
            #endregion


            Console.ReadLine();
        }
    }
}
