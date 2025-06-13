using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Looping
{
    class WhileLoop
    {
        /* 
         * A while loop statement in C# repeatedly executes a target statement as long as a given condition is true.
         */
        void whileLoop()
        {
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
        }
        public static void Example()
        {
            WhileLoop obj = new WhileLoop();
            obj.whileLoop();
        }
    }
}
