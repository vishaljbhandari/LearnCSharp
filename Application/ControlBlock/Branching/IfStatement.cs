using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Branching
{
    class IfStatement
    {
        void ifStatement()
        {
            /*
             *  An if statement consists of a boolean expression followed by one or more statements
             * 
             *  if(boolean_expression) {
             *      // statement(s) will execute if the boolean expression is true
             *  }
             * 
             */

            int a = 10;
            /* check the boolean condition using if statement */
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
        }

        void ifElseStatement()
        {
            /*
             *  An if statement consists of a boolean expression followed by one or more statements
             * 
             *  if(boolean_expression) {
             *      // statement(s) will execute if the boolean expression is true
             *  } else {
             *      // statement(s) will execute if the boolean expression is false
             *  }
             */

            int a = 100;
            /* check the boolean condition */
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            else
            {
                /* if condition is false then print the following */
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
        }

        void nestedIfStatement()
        {
            /*
             *  You can use one if or else if statement inside another if or else if statement(s).
             *  
             *  if( boolean_expression 1) {
             *      // Executes when the boolean expression 1 is true
             *      if (boolean_expression 2) {
             *          // Executes when the boolean expression 2 is true
             *      }
             *  }
             *  
             */

            int a = 100;
            int b = 200;
            /* check the boolean condition */
            if (a == 100)
            {

                /* if condition is true then check the following */
                if (b == 200)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
        }

        public static void Example()
        {
            IfStatement obj = new IfStatement();
            obj.ifStatement();
            obj.ifElseStatement();
            obj.nestedIfStatement();

        }
    }
}
