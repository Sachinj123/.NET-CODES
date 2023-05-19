using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0Demo_ENTITY_FRAMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CDAC_DBEntities it is the Partial Class Created in Cdac_DB.Context.cs
            //Emps is the reference created for DbSet<Emp> in Cdac_DB.Context.cs

            CDAC_DBEntities dbObject = new CDAC_DBEntities();


            #region SELECT USING ENTITY FRAMEWORK
            /*
            var allEmps = dbObject.Emps.ToList();
            foreach (var emp in allEmps)
            {
                Console.WriteLine(emp.No + " | " + emp.Name + " | " + emp.Address);

            }
            */
            #endregion


            #region INSERT USING ENTITY FRAMEWORK
            /*
            dbObject.Emps.Add(

                new Emp() { No = 7, Name = "Raviraj", Address = "Krushnawadi" }

                );

            dbObject.SaveChanges();

            var allEmps = dbObject.Emps.ToList();
            foreach (var emp in allEmps)
            {
                Console.WriteLine(emp.No + " | " + emp.Name + " | " + emp.Address);

            }
            */

            #endregion


            #region UPDATE USING ENTITY FRAMEWORK
            /*
            var empToModified = (from emp in dbObject.Emps.ToList()
                                 where emp.No == 7
                                 select emp).First();

            empToModified.Name = "Sonu";
            empToModified.Address = "Virar";

            dbObject.SaveChanges();
            Console.WriteLine("Table is Modified....");
            */
            #endregion


            #region DELETE USING ENTITY FRAMEWORK
            /*
            var empToDeleted = (from emp in dbObject.Emps.ToList()
                                 where emp.No == 7
                                 select emp).First();

            dbObject.Emps.Remove(empToDeleted);
            dbObject.SaveChanges();

            Console.WriteLine("Data is Removed...");
            */
            #endregion


            #region DATA INSERTED INTO TABLE USING STORED PROCEDURES
            /*
            dbObject.spInsert(6, "Raviraj", "Krushnawadi");
            Console.WriteLine("DATA INSERTED INTO TABLE USING STORED PROCEDURES....");
            */
            #endregion

            
            #region SELECT USING EF FOR CUSTOMER TABLE

            /*
            var cust = dbObject.Customers.ToList();

            foreach (var item in cust)
            {
                Console.WriteLine(item.CId + "  " + item.CName);

            }
            */
            #endregion



            Console.ReadLine();


        }
    }
}
