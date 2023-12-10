using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Enums
{
    class EnumType
    {
        /*
         * An enumeration 
         *  a set of named integer constants. 
         *  An enumerated type is declared using the enum keyword
         *  C# enumerations are value data type
         *      In other words, enumeration contains its own values and cannot inherit or cannot pass inheritance.
         */
        /*
            enum <enum_name> {
                enumeration list 
            };
         *   
         *  The enum_name specifies the enumeration type name
         *  The enumeration list is a comma-separated list of identifiers.
         *  
         *  Each of the symbols in the enumeration list stands for an integer value, one greater than the symbol that precedes it. 
         *  By default, the value of the first enumeration symbol is 0
        */
        enum Days { Sun,    // takes 0
            Mon,            // takes 1
            tue,            // takes 2
            Wed,            // takes 3
            thu,            // takes 4
            Fri,            // takes 5
            Sat             // takes 6
        };
        public static void Example()
        {
            int WeekdayStart = (int) Days.Mon;      // converting enum type to int type
            int WeekdayEnd = (int) Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
        }
    }
}
