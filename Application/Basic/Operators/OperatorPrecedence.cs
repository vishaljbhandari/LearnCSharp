using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class OperatorPrecedence
    {
        /*
         * Operator precedence determines the grouping of terms in an expression
         * This affects evaluation of an expression.
         * Certain operators have higher precedence than others
         * 
         * operators with the highest precedence appear at the top of the table, 
         * those with the lowest appear at the bottom. 
         * Within an expression, higher precedence operators are evaluated first.
         */

        public static void Example()
        {
            /*
                Category	Operator	Associativity
                Postfix	() [] -> . ++ - -	Left to right
                Unary	+ - ! ~ ++ - - (type)* & sizeof	Right to left
                Multiplicative	* / %	Left to right
                Additive	+ -	Left to right
                Shift	<< >>	Left to rights
                Relational	< <= > >=	Left to right
                Equality	== !=	Left to right
                Bitwise AND	&	Left to right
                Bitwise XOR	^	Left to right
                Bitwise OR	|	Left to right
                Logical AND	&&	Left to right
                Logical OR	||	Left to right
                Conditional	?:	Right to left
                Assignment	= += -= *= /= %=>>= <<= &= ^= |=	Right to left
                Comma	,	Left to right
            */
        }
    }
}
