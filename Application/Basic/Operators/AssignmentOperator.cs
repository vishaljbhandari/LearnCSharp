using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class AssignmentOperator
    {
        public static void Example()
        {
            int a = 16;
            int b = 60;
            int c;
            // =	Simple assignment operator, Assigns values from right side operands to left side operand
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = a + b = {2}", a, b, c);

            // +=	Add AND assignment operator, It adds right operand to the left operand and assign the result to left operand
            c += a;     // c = c + a
            Console.WriteLine("a = {0}, b = {1}, c += a = {2}", a, b, c);

            // -=	Subtract AND assignment operator, It subtracts right operand from the left operand and assign the result to left operand
            c -= a;     // c = c - a
            Console.WriteLine("a = {0}, b = {1}, c -= a = {2}", a, b, c);

            // *=	Multiply AND assignment operator, It multiplies right operand with the left operand and assign the result to left operand
            c *= a;     // c = c * a
            Console.WriteLine("a = {0}, b = {1}, c *= a = {2}", a, b, c);

            // /=	Divide AND assignment operator, It divides left operand with the right operand and assign the result to left operand
            c /= a;     // c = c / a
            Console.WriteLine("a = {0}, b = {1}, c /= a = {2}", a, b, c);

            // %=	Modulus AND assignment operator, It takes modulus using two operands and assign the result to left operand
            c %= a;     // c = c % a
            Console.WriteLine("a = {0}, b = {1}, c %= a = {2}", a, b, c);

            // <<=	Left shift AND assignment operator
            c <<= a;     // c = c << a
            Console.WriteLine("a = {0}, b = {1}, c <<= a = {2}", a, b, c);


            // >>=	Right shift AND assignment operator
            c >>= a;     // c = c >> a
            Console.WriteLine("a = {0}, b = {1}, c >>= a = {2}", a, b, c);

            // &=	Bitwise AND assignment operator
            c &= a;     // c = c & a
            Console.WriteLine("a = {0}, b = {1}, c &= a = {2}", a, b, c);

            // ^=	bitwise exclusive OR and assignment operator
            c ^= a;     // c = c ^ a
            Console.WriteLine("a = {0}, b = {1}, c ^= a = {2}", a, b, c);

            // |=	bitwise inclusive OR and assignment operator
            c |= a;     // c = c | a
            Console.WriteLine("a = {0}, b = {1}, c |= a = {2}", a, b, c);
        }
    }
}
