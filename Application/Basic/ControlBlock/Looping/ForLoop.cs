using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Looping
{
    class ForLoop
    {
        /*
         * for loop is a repetition control structure that allows you to efficiently write a loop that needs to execute a specific number of times.
         */
        void forLoop()
        {
            /*
                for ( init; condition; increment ) {
                   statement(s);
                }
            */
            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("value of a: {0}", a);
            }
        }
        public static void Example()
        {
            ForLoop obj = new ForLoop();
            obj.forLoop();
        }
    }
}
