using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Looping
{
    class DoWhileLoop
    {
        void doWhileLoop()
        {
            /*
             * A do...while loop is similar to a while loop, except that a do...while loop is guaranteed to execute at least one time.
             */
            int a = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a < 20);
        }
        public static void Example()
        {
            DoWhileLoop obj = new DoWhileLoop();
            obj.doWhileLoop();
        }
    }
}
