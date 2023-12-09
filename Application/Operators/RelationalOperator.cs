using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class RelationalOperator
    {
        public static void Example()
        {
            int a = 10;
            int b = 20;
            // ==	Checks if the values of two operands are equal or not, if yes then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a == b = {2}", a, b, a == b);
            // !=	Checks if the values of two operands are equal or not, if values are not equal then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a != b = {2}", a, b, a != b);
            // >	Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a > b = {2}", a, b, a > b);
            // <	Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a < b = {2}", a, b, a < b);
            // >=	Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a >= b = {2}", a, b, a >= b);
            // <=	Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a <= b = {2}", a, b, a <= b);
        }
    }
}
