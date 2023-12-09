using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class ArithmeticOperator
    {
        public static void Example()
        {
            int a = 10;
            int b = 20;

            // +	Adds two operands
            Console.WriteLine("a = {0}, b = {1}, c = a + b = {2}", a, b, a + b);
            // -	Subtracts second operand from the first
            Console.WriteLine("a = {0}, b = {1}, c = a - b = {2}", a, b, a - b);
            // *	Multiplies both operands
            Console.WriteLine("a = {0}, b = {1}, c = a * b = {2}", a, b, a * b);
            // /	Divides numerator by de-numerator
            Console.WriteLine("a = {0}, b = {1}, c = a / b = {2}", a, b, a / b);
            // %	Modulus Operator and remainder of after an integer division
            Console.WriteLine("a = {0}, b = {1}, c = a % b = {2}", a, b, a % b);
            // ++	Increment operator increases integer value by one
            Console.WriteLine("a = {0}, b = a++ = {2}", a, a++);
            // --	Decrement operator decreases integer value by one
            Console.WriteLine("a = {0}, b = a-- = {2}", a, a--);
        }
    }
}
