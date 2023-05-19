using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Demo_ModularLayer.POCO;
using System.Configuration;
using System.Data.SqlClient;

namespace _3Demo_ModularLayer.DAL
{
    public class SQLServer:IDatabase
    {
        public List<Emp> Select()
        {
            List<Emp> allEmployees = new List<Emp>();
              
            string constr = ConfigurationManager.ConnectionStrings
                 ["sqlconstring"].ToString();

            SqlConnection conn = new SqlConnection(constr);

            SqlCommand cmd = new SqlCommand("Select * from Emp", conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //THE BELOW SYNTAX IS KNOWN AS OBJECT INITIALIZER SYNTAX
                Emp emp = new Emp() 
                {
                    No = Convert.ToInt32(reader["No"]),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()
                };
                allEmployees.Add(emp);

            }
            conn.Close();

            return allEmployees;
        }

        public int Insert(Emp emp)
        {
            string constr = ConfigurationManager.ConnectionStrings
                 ["sqlconstring"].ToString();

            SqlConnection conn = new SqlConnection(constr);

            string queryFormat = "Insert into Emp values({0},'{1}','{2}')";
            string FinalQuery = string.Format(queryFormat, emp.No, emp.Name, emp.Address);

            SqlCommand cmd = new SqlCommand(FinalQuery, conn);
            conn.Open();

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            return rowsAffected;
        }

        public int Update(Emp emp)
        {
            return 0;
        }

        public int Delete(Emp emp)
        {
            return 0;
        }
    }
}
