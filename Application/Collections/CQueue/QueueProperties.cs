using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CQueue
{
    class BitArrayProperties
    {
        void propertyCount()
        {
            /* Count -> Gets the number of elements contained in the Queue */

            Queue queue = new Queue();

            Console.WriteLine("Count: {0} before Enqueue", queue.Count);
            queue.Enqueue(45); 
            queue.Enqueue(48);
            Console.WriteLine("Count: {0} after Enqueue", queue.Count);
            Console.WriteLine("Count: {0} before Dequeue", queue.Count);
            int value = (int)queue.Dequeue();
            Console.WriteLine("Dequeued Value {0}", value);
            Console.WriteLine("Count: {0} after Dequeue", queue.Count);
            CollectionHelper.PrintQueue(queue);
        }
        public static void Example()
        {
            BitArrayProperties obj = new BitArrayProperties();
            {
                obj.propertyCount();
            }

        }
    }
}
