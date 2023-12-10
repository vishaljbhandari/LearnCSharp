using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Nullable
{
    class NullCoalescingOperator
    {
        /*
         * The null coalescing operator
         *  used with the nullable value types and reference types. 
         *  used for converting an operand to the type of another nullable (or not) value type operand, where an implicit conversion is possible.
         */
        void nullCoalescingOperator()
        {
            /*
             * If the value of the first operand is null, 
             *      then the operator returns the value of the second operand
             *  otherwise it returns the value of the first operand
             * 
             */

            double? num1 = null;
            double? num2 = 3.14157;
            double num3;

            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
        }

        public static void Example()
        {
            NullCoalescingOperator obj = new NullCoalescingOperator();
            obj.nullCoalescingOperator();
        }
    }
}
