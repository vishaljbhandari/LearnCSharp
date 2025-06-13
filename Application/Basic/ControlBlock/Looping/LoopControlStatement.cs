using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Looping
{
    class LoopControlStatement
    {
        void BreakStatement()
        {
            /*
             * When the break statement is encountered inside a loop, 
             * the loop is immediately terminated and program control resumes at the next statement following the loop. 
             * It can be used to terminate a case in the switch statement.
             * The break statement is used to break/terminate the loop execution
             */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;

                if (a > 15)
                {
                    /* terminate the loop using break statement */
                    break;
                }
            }
        }

        void ContinueStatement()
        {
            /*
             * The continue statement is used to skip one or more iterations in the loop.
             * It then continues with the next iteration in the loop.
             */
            int a = 10;

            /* do loop execution */
            do
            {
                if (a == 15)
                {
                    /* skip the iteration */
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
        }
        public static void Example()
        {
            LoopControlStatement obj = new LoopControlStatement();
            obj.ContinueStatement();
            obj.BreakStatement();
        }
    }
}
