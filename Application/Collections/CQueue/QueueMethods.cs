using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CQueue
{
    class BitArrayMethods
    {
        void methodAdding()
        {
            /* 	
                public virtual object Dequeue();
                Removes and returns the object at the beginning of the Queue.
            */
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

        void methodSorting()
        {
            /* Stack are already sorted */
       }
       void methodClear()
       {
            /* 
             *  public virtual void Clear();
                Removes all elements from the Queue.
            */
            Queue queue = new Queue();
            queue.Enqueue("The");
            queue.Enqueue("QUICK");
            CollectionHelper.PrintQueue(queue);
            queue.Clear();
            Console.WriteLine("Count: {0} after clearing", queue.Count);
        }

        void methodRemoving()
        {
            /* 
                public virtual void Enqueue(object obj);
                Adds an object to the end of the Queue.
            */
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

        void methodInserting()
        {
            /* 
                No insert function
            */
        }

        void methodSearching()
        {
            /*                
                public virtual bool Contains(object obj);
                Determines whether an element is in the Queue.
             */
            Queue queue = new Queue();
            queue.Enqueue(45);
            queue.Enqueue(78);
            queue.Enqueue(33);
            if (queue.Contains(45))
            {
                Console.WriteLine("Value found in queue");
            }
        }
        void methodGets()
        {
            /* 
                public virtual object[] ToArray();
                Copies the Queue to a new array.
            */
            Queue queue = new Queue();
            queue.Enqueue(45);
            queue.Enqueue(78);
            queue.Enqueue(33);
            Object[] array = queue.ToArray();
            foreach (Object value in array)
            {
                Console.WriteLine(value);
            }
        }
        void methodTrimming()
        {
            /*
                public virtual void TrimToSize();
                Sets the capacity to the actual number of elements in the Queue
            */
            Queue queue = new Queue();
            queue.Enqueue(45);
            queue.Enqueue(78);
            queue.Enqueue(33);
            queue.Enqueue(36);
            queue.Enqueue(30);
            Console.WriteLine("Count: {0}", queue.Count);
            queue.TrimToSize();
            Console.WriteLine("Count: {0}", queue.Count);
            CollectionHelper.PrintQueue(queue);
        }

        public static void Example()
        {
            BitArrayMethods obj = new BitArrayMethods();
            {
                obj.methodAdding();
                obj.methodSorting();
                obj.methodClear();
                obj.methodRemoving();
                obj.methodInserting();
                obj.methodSearching();
                obj.methodGets();
                obj.methodTrimming();
            }
        }
    }
}
