using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0DemoPARTIAL_METHOD
{
    //DEVELOPER 1 
    public partial class Employee
    {
		//HERE METHOD IS JUST DECLARED YET TO DEFINE
		partial void Validate(string propertyName, object Value);
		private int _Age;

		public int Age
		{
			get { return _Age; }
			set
			{
				Validate("Age", value);
				//THE ABOVE METHOD IS PARTIAL METHOD
				//TILL NOT DECLARED IN FILE1.CS BUT WE HAVE TO USE
				_Age = value;
			}
		}


	}
}
