using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DemoPartialClass
{
    public partial class Maths
    {
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    // V.V.IMP -------->

    // public class Maths ------> I f we create the same name class 2 times then it will give ERROR
    // BECAUSE "Maths" class is already present in "File1.cs"

    // With the use of "PARTIAL" Keyword in class declaration we can DECLARE SAME CLASS NAME in the Project  


}
