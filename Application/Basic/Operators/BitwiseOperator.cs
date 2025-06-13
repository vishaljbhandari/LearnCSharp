using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class BitwiseOperator
    {
        public static void Example()
        {
            int a = 16;
            int b = 60;
            // &	Binary AND Operator copies a bit to the result if it exists in both operands.
            Console.WriteLine("a = {0}, b = {1}, c = a & b = {2}", a, b, a & b);
            // |	Binary OR Operator copies a bit if it exists in either operand.
            Console.WriteLine("a = {0}, b = {1}, c = a | b = {2}", a, b, a | b);
            // ^	Binary XOR Operator copies the bit if it is set in one operand but not both.
            Console.WriteLine("a = {0}, b = {1}, c = a ^ b = {2}", a, b, a ^ b);
            // ~	Binary Ones Complement Operator is unary and has the effect of 'flipping' bits.
            Console.WriteLine("a = {0}, b = ~a = {1}", a, ~a);
            // <<	Binary Left Shift Operator. The left operands value is moved left by the number of bits specified by the right operand.
            Console.WriteLine("a = {0}, b = a << 2 = {1}", a, a << 2);
            // >>	Binary Right Shift Operator. The left operands value is moved right by the number of bits specified by the right operand.
            Console.WriteLine("a = {0}, b = a >> 2 = {1}", a, a >> 2);
        }
    }
}
