using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CSortedList
{
    class StackMethods
    {
        void methodAdding()
        {
            /* 	
                public virtual int Add(object key, object value);
                Adds an object to the end of the SortedList.
            */
            SortedList al = new SortedList();

            Console.WriteLine("Adding some numbers:");
            al.Add(1, 45);
            al.Add(2, 78);
            al.Add(3, 33);
            
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
            CollectionHelper.PrintSortedList(al);
        }

        void methodSorting()
        {
            /* SortedList are already sorted */
       }
       void methodClear()
       {
           /* 
            *  public virtual void Clear();
               Removes all elements from the SortedList 
           */
            SortedList mySL = new SortedList();
            mySL.Add(1, "The");
            mySL.Add(2, "QUICK");
            mySL.Clear();
            CollectionHelper.PrintSortedList(mySL);
            Console.WriteLine("Count: {0} after clearing", mySL.Count);
            Console.WriteLine("Capacity: {0} ", mySL.Capacity);
        }

        void methodRemoving()
        {
            /* 

                public virtual void Remove(object key);
                Removes the element with the specified key from the SortedList.


                public virtual void RemoveAt(int index);
                Removes the element at the specified index of SortedList.
            */
            SortedList mySL = new SortedList();
            mySL.Add(1, "The");
            mySL.Add(2, "QUICK");
            mySL.Add(3, "BROWN");
            mySL.Add(4, "FOX");
            mySL.Add(5, "jumps");
            mySL.Add(6, "Run");
            mySL.Add(7, "Hello");
            mySL.Add(8, "Dog");
            mySL.Add(9, "Walk");
            mySL.Add(10, "Hi");
            mySL.Add(11, "Cat");
            mySL.Add(12, "Climbs");
            Console.WriteLine("Before Remove");
            CollectionHelper.PrintSortedList(mySL);
            mySL.Remove(2);         // removes element with key = 2
            mySL.RemoveAt(4);       // removes element at 4th index
            Console.WriteLine("After Remove");
            CollectionHelper.PrintSortedList(mySL);
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
                public virtual int IndexOfKey(object key);
                Returns the zero-based index of the specified key in the SortedList

                public virtual int IndexOfValue(object value);
                Returns the zero-based index of the first occurrence of the specified value in the SortedList

                public virtual bool ContainsKey(object key);
                Determines whether the SortedList contains a specific key.
                
                public virtual bool ContainsValue(object value);
                Determines whether the SortedList contains a specific value.
             */
            SortedList myAL = new SortedList();
            myAL.Add(1, "The");
            myAL.Add(2, "BROWN");
            myAL.Add(3, "FOX");
            myAL.Add(4, "jumps");
            myAL.Add(5, "Run");
            myAL.Add(6, "Hello");
            myAL.Add(7, "Dog");
            myAL.Add(8, "Walk");
            if (myAL.ContainsValue("Run"))
            {
                Console.WriteLine("Value found");
            }
            if (myAL.ContainsKey(5))
            {
                Console.WriteLine("Key found");
            }
            Console.WriteLine("Key found at {0}", myAL.IndexOfKey(5));
            Console.WriteLine("Value found at {0}", myAL.IndexOfValue("Run"));
        }
        void methodGets()
        {
            /* 
                public virtual object GetByIndex(int index);
                Gets the value at the specified index of the SortedList.

                public virtual object GetKey(int index);
                Gets the key at the specified index of the SortedList.

                public virtual IList GetKeyList();
                Gets the keys in the SortedList.

                public virtual IList GetValueList();
                Gets the values in the SortedList.
            */
            SortedList myAL = new SortedList();
            myAL.Add(1, "The");
            myAL.Add(2, "BROWN");
            myAL.Add(3, "FOX");
            myAL.Add(4, "jumps");
            myAL.Add(5, "Run");
            myAL.Add(6, "Hello");
            myAL.Add(7, "Dog");
            myAL.Add(8, "Walk");
            Console.WriteLine("Value at index 5 is {0}", myAL.GetByIndex(5));
            Console.WriteLine("Key at index 5 is {0}", myAL.GetKey(5));

            ICollection keyList = myAL.GetKeyList();
            foreach (string key in keyList)
            {
                Console.WriteLine(key + ": " + myAL[key]);
            }
            ICollection valueList = myAL.GetValueList();
            foreach (string value in valueList)
            {
                Console.WriteLine(value);
            }
        }
        void methodMisc()
        {
            /*
                public virtual void TrimToSize();
                Sets the capacity to the actual number of elements in the SortedList.
             */
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
                obj.methodMisc();
            }
        }
    }
}
