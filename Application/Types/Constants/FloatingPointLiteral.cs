using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Constants
{
    class FloatingPointLiteral
    {
        /*
         * 
         * A floating-point literal has an integer part, a decimal point, a fractional part, and an exponent part. 
         * You can represent floating point literals either in decimal form or exponential form.
         */

        public static void Example()
        {
            {
                // float
                float a = 3.56f;
                Console.WriteLine(a);
                // float
                float b = 3.14159f;
                Console.WriteLine(b);
            }
            {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
                double d1 = 3.14145;        // Valid
#pragma warning restore CS0219 // Variable is assigned but its value is never used
                double d2 = 312569E-5;      // Valid
                                            // double d3 = 125E;           // invalid: Incomplete exponent 
#pragma warning disable CS0219 // Variable is assigned but its value is never used
                double d4 = 784f;           // valid
#pragma warning restore CS0219 // Variable is assigned but its value is never used
                              // double d5 = .e45;           // invalid: missing integer or fraction

                Console.WriteLine(d2);
                // decimal-form literal
                double a = 101.230;

                // It also acts as decimal literal
                double b = 0123.222;

                Console.WriteLine(a);
                Console.WriteLine(b);

                double d = 0.42e2;
                Console.WriteLine(d);  // output 42

                float f = 134.45E-2f;
                Console.WriteLine(f);  // output: 1.3445

                decimal m = 1.5E6m;
                Console.WriteLine(m);  // output: 1500000
            }

        }
    }
}
