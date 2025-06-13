using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class LogicalOperator
    {
        public static void Example()
        {
            int a = 10;
            int b = 20;
            // &&	Called Logical AND operator. If both the operands are non zero then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a == b && a == 10 = {2}", a, b, a == b && a == 10);
            // ||	Called Logical OR Operator. If any of the two operands is non zero then condition becomes true.
            Console.WriteLine("a = {0}, b = {1}, c = a == b || a == 10 = {2}", a, b, a == b || a == 10);
            // !	Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false.
            Console.WriteLine("a = {0}, b = {1}, c = !(a > b) = {2}", a, b, !(a > b));
        }
    }
}
