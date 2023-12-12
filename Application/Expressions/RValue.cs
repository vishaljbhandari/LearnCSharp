using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Expressions
{
    class RValue
    {
        void rvalue()
        {
            /* literals are rvalues and hence they may not be assigned and can not appear on the left-hand side */
            // 10 = 20; // compile-time error 
            // 'A' = 5; // compile-time error 
        }
        void rvalueExpression()
        {
            /* rvalue − An expression that is an rvalue may appear on the right- but not left-hand side of an assignment */
        }
        public static void Example()
        {
            RValue obj = new RValue();
            obj.rvalueExpression();
        }
    }
}
