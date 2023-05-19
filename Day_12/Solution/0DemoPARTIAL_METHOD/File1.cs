using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0DemoPARTIAL_METHOD
{
    //DEVELOPER - 2
    public partial class Employee
    {
        partial void Validate(string propertyName, object Value)
        {
            //PARTIAL METHODS ONLY DECLARD IN PARTIAL METHOD
            //THIS IS THE FIRST CRITERIA

            //PARTIAL METHODS ARE BY DEFAULT "PRIAVTE"
            //THEY CAN NOT BE CALL OUTSIDE OF THE CLASS

            //RETURN TYPE OF THE PARTIAL METHOD IS ALWAYS "VOID"

            if(propertyName == "Age")
            {
                int age = Convert.ToInt32(Value);
                {
                    if(age <= 18)
                    {
                        Console.WriteLine("You Can't Vote");
                    }
                    else
                    {
                        Console.WriteLine("You Can Vote");
                    }
                }
            }
        }
    }
}
