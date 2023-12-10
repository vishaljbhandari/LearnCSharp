using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CString
{
    class StringClassProperties
    {
        void classProperties()
        {
            /* String class has the following two properties */
            /* 1. Chars -> Gets the Char object at a specified position in the current String object */
            /* 2. Length -> Gets the number of characters in the current String object */
            string name = new string("Hello");
            Console.WriteLine("Length of name - {0}", name.Length);
        }
        public static void Example()
        {
            StringClassProperties obj = new StringClassProperties();
            obj.classProperties();
        }
    }
}
