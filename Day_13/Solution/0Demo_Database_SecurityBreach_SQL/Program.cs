using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0Demo_Database_SecurityBreach_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CDAC_DB;Integrated Security=True;Pooling=False";

            SqlConnection conn = new SqlConnection(constr);

            Console.WriteLine("Enter Name: ");

           // string cmdText = "Select * from Emp where Name = '" + Console.ReadLine() + "'";

            string cmdText = "Select count (*) from Emp where Name = '" + Console.ReadLine() + "'";
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();

            /*SqlDataReader reader = cmd.ExecuteReader();

            //It is used when "select * from emp 
            while (reader.Read())
            {
                Console.WriteLine(string.Format("{0}, {1}, {2}", reader[0], reader[1], reader[2]));
            }*/

            object result = cmd.ExecuteScalar();
            int count = Convert.ToInt32(result);

            if(count > 0 )
            {
                Console.WriteLine("You are a Valid User ...");
            }
            else
            {
                Console.WriteLine("You are Invalid User...");
            }
            conn.Close();
            Console.ReadLine();
        }
    }
}
