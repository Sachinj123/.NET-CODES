using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DemoLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HERE WE USE LIST COLLECTION
            List<Employee> emps = new List<Employee>()
            {
                new Employee { Id = 11, Name = "SACHIN", Address = "MUMBAI" },
                new Employee { Id = 12, Name = "SAMPADA", Address = "PUNE" },
                new Employee { Id = 13, Name = "NITIN", Address = "MUKHED" },
                new Employee { Id = 14, Name = "VISHAL", Address = "VISHNUPURI" },
                new Employee { Id = 15, Name = "SONU", Address = "VIRAR" }
            };
            
            Console.WriteLine("Enter City Search Character:");
            string cityFilter = Console.ReadLine();

            //var result = new List<Employee>();

            /* foreach (Employee emp in emps)
            {
                //if (emp.Address.StartsWith(cityFilter))
                //if (emp.Address.Contains(cityFilter))
                if (emp.Address.EndsWith(cityFilter))
                {
                    result.Add(emp);
                }

            }*/

            #region LINQ WITHOUT TOLIST
            /*var result = from emp in emps
                             //where emp.Address.Contains(cityFilter)
                             where emp.Address.StartsWith(cityFilter)
                             select emp;*/

            //WHEN WE SEARCH FOR STARTSWITH = M THEN OUTPUT IS 3 SACHIN,NITIN,MAYUR
            //THE ABOVE QUERY IS NOT EXECUTE HERE  (Control goest at line number 67)

            #endregion


            #region LINQ WITH TOLIST
            /*var result = (from emp in emps
                            where emp.Address.StartsWith(cityFilter)
                            select emp).ToList();


               //WHEN WE SEARCH FOR STARTSWITH = M THEN OUTPUT IS 2 SACHIN,NITIN
               //THE ABOVE QUERY IS EXECUTE HERE BECAUSE WE USE HERE  -----> ToList(). */ 
            #endregion

           /* emps.Add(new Employee() { Id = 16, Name = "MAYUR", Address = "MANMAD" });
            Console.WriteLine("Filtered Result:");

            //THE ABOVE QUERY IS EXECUTE HERE BECAUSE WE USE RESULT HERE
            //WHENEVER WE USE RESULT AT WHAT PLACE THAT PLACE QUERY IS EXECCUTE

            foreach (Employee e in result)
            {
                Console.WriteLine(e.Name +" is from "+e.Address);

            }*/



            var result = (from emp in emps
                          where emp.Address.StartsWith(cityFilter)
                          select new ResultHolder
                          {
                              EName = "Mr / Mrs " + emp.Name,
                              ECity = emp.Address

                          }).ToList();


          Console.WriteLine("Filtered Result:");

            foreach (var e in result)
            {
                Console.WriteLine(e.EName + " is from " + e.ECity);

            }

            Console.ReadLine(); 
        }
        
    }

     public class Employee
     {
         public int Id { get; set; }

          public string Name { get; set; }

          public string Address { get; set; }
     }

    public class ResultHolder
    {
        public string EName { get; set; }

        public string ECity { get; set; }
    }
}

   

