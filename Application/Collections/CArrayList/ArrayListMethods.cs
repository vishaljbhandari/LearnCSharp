using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CArrayList
{
    class ArrayListMethods
    {
        void methodAdding()
        {
            /* 	
                public virtual int Add(object value);
                Adds an object to the end of the ArrayList.
            */
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
            CollectionHelper.PrintArrayList(al);
            /*
                public virtual void AddRange(ICollection c);
                Adds the elements of an ICollection to the end of the ArrayList. 
            */
            var arlist = new ArrayList();
            var arlistdata = new ArrayList() { 1, "Bill", " ", true, 4.5, null };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist.AddRange(arlistdata);  //adding arraylist in arraylist 
            arlist.AddRange(arr);      //adding array in arraylist 
            arlist.AddRange(myQ);      //adding Queue in arraylist 
            CollectionHelper.PrintArrayList(arlist);
        }

        void methodSorting()
        {
            /* 	
                public virtual void Sort ();
                Sorts the elements in the ArrayList.

                public virtual void Sort (System.Collections.IComparer? comparer);
            */
            ArrayList myAL1 = new ArrayList();
            myAL1.Add("The");
            myAL1.Add("quick");
            myAL1.Add("brown");
            myAL1.Add("fox");
            myAL1.Add("jumps");
            myAL1.Add("over");
            myAL1.Add("the");
            myAL1.Add("lazy");
            myAL1.Add("dog");

            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList initially contains the following values:");
            CollectionHelper.PrintArrayList(myAL1);

            // Sorts the values of the ArrayList using the default comparer.
            myAL1.Sort();
            Console.WriteLine("After sorting with the default comparer:");
            CollectionHelper.PrintArrayList(myAL1);

            // Sorts the values of the ArrayList using the reverse case-insensitive comparer.
            IComparer myComparer = new myReverserClass();
            myAL1.Sort(myComparer);
            Console.WriteLine("After sorting with the reverse case-insensitive comparer:");
            CollectionHelper.PrintArrayList(myAL1);
            /*
                public virtual void Sort (int index, int count, System.Collections.IComparer? comparer);
            */
            ArrayList myAL2 = new ArrayList();
            myAL2.Add("The");
            myAL2.Add("QUICK");
            myAL2.Add("BROWN");
            myAL2.Add("FOX");
            myAL2.Add("jumps");
            myAL2.Add("over");
            myAL2.Add("the");
            myAL2.Add("lazy");
            myAL2.Add("dog");

            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList initially contains the following values:");
            CollectionHelper.PrintArrayList(myAL2);

            // Sorts the values of the ArrayList using the default comparer.
            myAL2.Sort(1, 3, null);
            Console.WriteLine("After sorting from index 1 to index 3 with the default comparer:");
            CollectionHelper.PrintArrayList(myAL2);

            // Sorts the values of the ArrayList using the reverse case-insensitive comparer.
            myAL2.Sort(1, 3, myComparer);
            Console.WriteLine("After sorting from index 1 to index 3 with the reverse case-insensitive comparer:");
            CollectionHelper.PrintArrayList(myAL2);
        }
        void methodClear()
        {
            /* 
             *  public virtual void Clear();
                Removes all elements from the ArrayList 
            */
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("QUICK");
            myAL.Add("BROWN");
            myAL.Add("FOX");
            myAL.Add("jumps");
            myAL.Clear();
            CollectionHelper.PrintArrayList(myAL);
            Console.WriteLine("Count: {0} after clearing", myAL.Count);
            Console.WriteLine("Capacity: {0} ", myAL.Capacity);
        }

        void methodReverse()
        {
            /* 
             *  public virtual void Reverse();
                Reverses the order of the elements in the ArrayList.
            */
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("QUICK");
            myAL.Add("BROWN");
            myAL.Add("FOX");
            myAL.Add("jumps");
            Console.WriteLine("Before Reverse");
            CollectionHelper.PrintArrayList(myAL);
            myAL.Reverse();
            Console.WriteLine("After Reverse");
            CollectionHelper.PrintArrayList(myAL);
        }

        void methodRemoving()
        {
            /* 
                public virtual void Remove(object obj);
                Removes the first occurrence of a specific object from the ArrayList.

                public virtual void RemoveAt(int index);
                Removes the element at the specified index of the ArrayList.

                public virtual void RemoveRange(int index, int count);
                Removes a range of elements from the ArrayList.
            */
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("QUICK");
            myAL.Add("BROWN");
            myAL.Add("FOX");
            myAL.Add("jumps");
            myAL.Add("Run");
            myAL.Add("Hello");
            myAL.Add("Dog");
            myAL.Add("Walk");
            myAL.Add("Hi");
            myAL.Add("Cat");
            myAL.Add("Climbs");
            Console.WriteLine("Before Remove");
            CollectionHelper.PrintArrayList(myAL);
            myAL.Remove("The");     // removing single element
            myAL.Remove(2);         // removing element at 2nd index
            myAL.RemoveRange(4, 3);         // removes three elements starting at index 4
            Console.WriteLine("After Remove");
            CollectionHelper.PrintArrayList(myAL);
        }

        void methodInserting()
        {
            /* 
                public virtual void Insert(int index, object value);
                Inserts an element into the ArrayList at the specified index.
	
                public virtual void InsertRange(int index, ICollection c);
                Inserts the elements of a collection into the ArrayList at the specified index.
            */
            ArrayList myAL = new ArrayList();
            myAL.Add("The");            
            myAL.Add("BROWN");
            myAL.Add("FOX");
            myAL.Add("jumps");
            myAL.Add("Run");
            myAL.Add("Hello");
            myAL.Add("Dog");
            myAL.Add("Walk");
            Console.WriteLine("Before Insert");
            CollectionHelper.PrintArrayList(myAL);
            myAL.Insert(2, "QUICK");            // Inserting element at 2nd index
            myAL.Insert(3, "Fast");
            myAL.Insert(6, "Run");
            ArrayList myAL2 = new ArrayList();
            myAL2.Add("Run");
            myAL2.Add("Hello");
            myAL2.Add("Dog");   
            myAL.Insert(6, myAL2);              // Inserting collection at 6th index
            Console.WriteLine("After Insert");
            CollectionHelper.PrintArrayList(myAL);
        }

        void methodSearching()
        {
            /*
                public virtual int IndexOf(object);
                Returns the zero-based index of the first occurrence of a value in the ArrayList or in a portion of it.

                public virtual int LastIndexOf(object);
                Returns the zero-based index of the last occurrence of a value in the ArrayList or in a portion of it.

                public virtual bool Contains(object item);
                Determines whether an element is in the ArrayList.
             */
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("BROWN");
            myAL.Add("FOX");
            myAL.Add("jumps");
            myAL.Add("Run");
            myAL.Add("Hello");
            myAL.Add("Dog");
            myAL.Add("Walk");
            if (myAL.Contains("Run"))
            {
                Console.WriteLine("Element found");
            }
            Console.WriteLine("Element found at {0}", myAL.IndexOf("Run"));
            Console.WriteLine("Element found at {0}", myAL.LastIndexOf("Run"));
        }
        void methodMisc()
        {
            /* 
                public virtual void SetRange(int index, ICollection c);
                Copies the elements of a collection over a range of elements in the ArrayList.

            	
                public virtual ArrayList GetRange(int index, int count);
                Returns an ArrayList which represents a subset of the elements in the source ArrayList.
            */

            /*
                public virtual void TrimToSize();
                Sets the capacity to the actual number of elements in the ArrayList.
             */
        }


        public static void Example()
        {
            ArrayListMethods obj = new ArrayListMethods();
            {
                obj.methodAdding();
                obj.methodSorting();
                obj.methodClear();
                obj.methodReverse();
                obj.methodRemoving();
                obj.methodInserting();
                obj.methodSearching();
                obj.methodMisc();
            }
        }
        public class myReverserClass : IComparer
        {
            // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }
    }
}
