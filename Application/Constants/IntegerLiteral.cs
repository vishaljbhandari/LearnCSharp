using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Constants
{
    class IntegerLiteral
    {
        /*
         * An integer literal can be a decimal, or hexadecimal constant. 
         * A prefix specifies the base or radix: 0x or 0X for hexadecimal, and there is no prefix id for decimal.
         * An integer literal can also have a suffix that is a combination of U and L, for unsigned and long, respectively. 
         * The suffix can be uppercase or lowercase and can be in any order.
        */
        public static void Example()
        {
            const decimal d1 = 85;
            const int int1 = 85;
            const uint uInt = 85u;
            const long lng = 85;
            const ulong ulng = 30ul;

            Console.WriteLine("Decimal variable {0}", d1);
            Console.WriteLine("Unsigned int variable {0}", uInt);
            Console.WriteLine("Int variable {0}", int1);
            Console.WriteLine("Unsigned int variable {0}", uInt);
            Console.WriteLine("Long variable {0}", lng);
            Console.WriteLine("Unsigned Long variable {0}", ulng);
        }
    }
}
