using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.ReferenceType
{
    class StringType
    {
        /*
         * The String Type allows you to assign any string values to a variable
         * The string type is an alias for the System.String class
         * It is derived from object type
         * The value for a string type can be assigned using string literals in two forms: quoted and @quoted
         */

        public static void Example()
        {
            String str = "Tutorials Point";
            Console.WriteLine(str);
        }
    }
}
