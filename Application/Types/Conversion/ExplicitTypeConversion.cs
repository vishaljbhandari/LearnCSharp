using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Conversion
{
    class ExplicitTypeConversion
    {
        /*
         * These conversions are done explicitly by users using the pre-defined functions.
         * Explicit conversions require a cast operator.
         * 
         */

        public static void Example()
        {
            double d = 5673.74;
            int i;

            // cast double to int.
            i = (int)d;
            Console.WriteLine(i);
        }
    }
}
