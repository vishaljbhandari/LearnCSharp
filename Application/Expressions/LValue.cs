using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Expressions
{
    class LValue
    {
        void lvalues()
        {
            /* Variables are lvalues and hence they may appear on the left-hand side of an assignment */
        }
        void lvalueExpression()
        {
            /* lvalue − An expression that is an lvalue may appear as either the left-hand or right-hand side of an assignment */
        }
        public static void Example()
        {
            LValue obj = new LValue();
            obj.lvalues();
            obj.lvalueExpression();
        }
    }
}
