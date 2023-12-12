using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CStack
{
    class QueueProperties
    {
        void propertyCount()
        {
            /* Count -> Gets the number of elements contained in the Stack */

            Stack sl = new Stack();

            Console.WriteLine("Count: {0} before pushing", sl.Count);
            sl.Push(45); 
            sl.Push(48);
            Console.WriteLine("Count: {0} after pushing", sl.Count);
            Console.WriteLine("Count: {0} before popping", sl.Count);
            int value = (int) sl.Pop();
            Console.WriteLine("Popped Value {0}", value);
            Console.WriteLine("Count: {0} after popping", sl.Count);
            CollectionHelper.PrintStack(sl);
        }
        public static void Example()
        {
            QueueProperties obj = new QueueProperties();
            {
                obj.propertyCount();
            }

        }
    }
}
