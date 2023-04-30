using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9DemoDictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "SACHIN");
            dictionary.Add(2, "SAMPUZZZ");
            dictionary.Add(3, "Vishal");

            foreach(int key in dictionary.Keys)
            {
                Console.WriteLine("Data Available at Key:"+key.ToString());
                Console.WriteLine(dictionary[key]);
            }

            Console.ReadLine();
        }
    }
}
