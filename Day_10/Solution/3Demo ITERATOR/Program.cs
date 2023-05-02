using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Demo_ITERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Week w = new Week();

            foreach(string day in w)
            {
                Console.WriteLine(day);

            }

            Console.ReadLine();

        }
    }

//IEnumerable ---> GetEnumerator method  it is used to traverse the collection
    public class Week : IEnumerable
    {
        private string[] days = 
            new string[] { "Monday", "Tuesday", "Wed","Thursday","Friday","Saturday","Sunday" };

        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<days.Length;i++)
            {
               yield return days[i];
            }
        }
    }
}
