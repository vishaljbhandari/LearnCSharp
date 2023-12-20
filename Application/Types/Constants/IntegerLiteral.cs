using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Constants
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
            {
                
                const decimal d1 = 85;          /* decimal */
                const int int1 = 85;            /* int */
                const uint uInt = 85u;          /* unsigned int */
                const long lng = 85;            /* long */
                const ulong ulng = 30ul;        /* unsigned long */
                Console.WriteLine("Decimal variable {0}", d1);
                Console.WriteLine("Unsigned int variable {0}", uInt);
                Console.WriteLine("Int variable {0}", int1);
                Console.WriteLine("Unsigned int variable {0}", uInt);
                Console.WriteLine("Long variable {0}", lng);
                Console.WriteLine("Unsigned Long variable {0}", ulng);
            }
            {

                /*
                 * Decimal literals / decimal constants
                 * Decimal system numbers, Digits from 0 to 9
                 */
                const int x = 10;         // x = 10
                float y = 4 * 10;     // y = 40
                if (x > 5)
                    y = x / 0xa;  // y = 1

                Console.WriteLine(y.ToString());

                /* a Decimal value using the default ToString() method. 
                 * It also displays the string representations of the Decimal value that result from using a number of standard format specifiers.
                 */
                decimal value = -16325.62m;
                // Display value using default ToString method.
                Console.WriteLine(value.ToString());            // Displays -16325.62
                                                                // Display value using some standard format specifiers.
                Console.WriteLine(value.ToString("G"));         // Displays -16325.62
                Console.WriteLine(value.ToString("C"));         // Displays ($16,325.62)
                Console.WriteLine(value.ToString("F"));         // Displays -16325.62

                decimal MyFortune = 5247581245;
                Console.WriteLine(MyFortune.ToString("C"));                
            }

            {
                /*
                 * Octal Literal
                 * Constants of octal numeral system combination of digits from 0 up to 7
                 */
                const int x = 012;         // x = 10
                int y = 4 * 077;     // y = 374
                if (x > 10)
                    y = x / 0xa;   // y = 1
                Console.WriteLine("y: " + y);

                /*
                 * To represent Int32 as a Octal string in C#, use the ToString() method and set the base as the ToString() method’s second parameter i.e. 8 for Octal.
                 * Int32 represents a 32-bit signed integer.
                 */

                int val = 99;
                Console.WriteLine("Integer: " + val);
                Console.Write("Octal String: " + Convert.ToString(val, 8));
            }

            {
                /*
                 * Hexadecimal Literal / base 16 constant
                 * it is from combination of following hexadecimal digits
                 *      0, 1, 2, 3, 4, 5, 6, 7, 8, 9, a/A, b/B, c/C, d/D, e/E, f/F
                 */

                const int x = 0x1234;       // x = 4660
                int y = 4 * 0xff;     // y = 1020
                if (x > 0xabc)
                    y = x / 0xa;    // y = 466
                Console.WriteLine("y: " + y);

                /*
                 * 
                 * The hexadecimal ("X") format specifier is used to convert a number to a string of hexadecimal digits.
                 * Set the case of the format specifier for uppercase or lowercase characters to be worked on hexadecimal digits greater than 9
                 * “X” for PQR, whereas “x” for pqr
                */
                int num;
                num = 345672832;
                Console.WriteLine(num.ToString("X"));
                Console.WriteLine(num.ToString("X2"));
                num = 0x307e;
                Console.WriteLine(num.ToString("x"));
                Console.WriteLine(num.ToString("X"));
            }
        }
    }
}
