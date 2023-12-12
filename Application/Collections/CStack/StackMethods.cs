using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CStack
{
    class StackMethods
    {
        void methodAdding()
        {
            /* 	
                public virtual void Push(object obj);
                Inserts an object at the top of the Stack
            */
            Stack stack = new Stack();

            Console.WriteLine("Pushing some numbers:");
            stack.Push(45);
            stack.Push(78);
            stack.Push(33);            
            Console.WriteLine("Count: {0} after pushing", stack.Count);
            CollectionHelper.PrintStack(stack);
        }

        void methodSorting()
        {
            /* Stack are already sorted */
       }
       void methodClear()
       {
            /* 
             *  public virtual void Clear();
                Removes all elements from the Stack
            */
            Stack mySL = new Stack();
            mySL.Push("The");
            mySL.Push("QUICK");
            CollectionHelper.PrintStack(mySL);
            mySL.Clear();
            Console.WriteLine("Count: {0} after clearing", mySL.Count);
        }

        void methodRemoving()
        {
            /* 

                public virtual object Pop();
                Removes and returns the object at the top of the Stack.
            */
            Stack stack = new Stack();

            Console.WriteLine("Pushing some numbers:");
            stack.Push(45);
            stack.Push(78);
            stack.Push(33);
            Console.WriteLine("Popping number");
            int value = (int) stack.Pop();
            Console.WriteLine("Count: {0} after popping", stack.Count);
            Console.WriteLine("Popped Item: {0}", value);
            CollectionHelper.PrintStack(stack);
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
                public virtual bool Contains(object value);
                Determines whether an element is in the Stack.
             */
            Stack stack = new Stack();
            stack.Push(45);
            stack.Push(78);
            stack.Push(33);
            if (stack.Contains(45))
            {
                Console.WriteLine("Value found in stack");
            }
        }
        void methodGets()
        {
            /* 
                public virtual object[] ToArray();
                Copies the Stack to a new array
            */
            Stack stack = new Stack();
            stack.Push(45);
            stack.Push(78);
            stack.Push(33);
            Object[] array = stack.ToArray();
            foreach (Object value in array)
            {
                Console.WriteLine(value);
            }
        }
        void methodPeeking()
        {
            /*
                public virtual object Peek();
                Returns the object at the top of the Stack without removing it
            */
            Stack stack = new Stack();
            stack.Push(45);
            stack.Push(78);
            stack.Push(33);
            int value = (int)stack.Peek();
            Console.WriteLine("Count: {0} with Peek", stack.Count);
            Console.WriteLine("Peeked Item: {0}", value);
            CollectionHelper.PrintStack(stack);
        }

        public static void Example()
        {
            StackMethods obj = new StackMethods();
            {
                obj.methodAdding();
                obj.methodSorting();
                obj.methodClear();
                obj.methodRemoving();
                obj.methodInserting();
                obj.methodSearching();
                obj.methodGets();
                obj.methodPeeking();
            }
        }
    }
}
