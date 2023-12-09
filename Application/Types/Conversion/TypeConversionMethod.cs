using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Conversion
{
    class TypeConversionMethod
    {
        /*
         * C# provides the following built-in type conversion methods
         */
        public static void Example()
        {
            {
                /* ToBoolean() -> Converts a type to a Boolean value, where possible */
            }
            {
                /* ToByte() -> Converts a type to a byte */
            }
            {
                /* ToChar()-> Converts a type to a single Unicode character, where possible */
            }
            {
                /* ToDateTime()-> Converts a type (integer or string type) to date-time structures */
            }
            {
                /* ToDecimal()-> Converts a floating point or integer type to a decimal type */
            }
            {
                /* ToDouble()-> Converts a type to a double type */
            }
            {
                /* ToInt16()-> Converts a type to a 16-bit integer */
            }
            {
                /* ToInt32()-> Converts a type to a 32-bit integer */
            }
            {
                /* ToInt64()-> Converts a type to a 64-bit integer */
            }
            {
                /* ToSbyte()-> Converts a type to a signed byte type */
            }
            {
                /* ToSingle()-> Converts a type to a small floating point number */
            }
            {
                /* ToString()-> Converts a type to a string */
                int i = 75;
                float f = 53.005f;
                double d = 2345.7652;
                bool b = true;

                Console.WriteLine(i.ToString());
                Console.WriteLine(f.ToString());
                Console.WriteLine(d.ToString());
                Console.WriteLine(b.ToString());
            }
            {
                /* ToType()-> Converts a type to a specified type */
            }
            {
                /* ToUInt16()-> Converts a type to an unsigned int type */
            }
            {
                /* ToUInt32()-> Converts a type to an unsigned long type */
            }
            {
                /* ToUInt64()-> Converts a type to an unsigned big integer */
            }
        }
    }
}
