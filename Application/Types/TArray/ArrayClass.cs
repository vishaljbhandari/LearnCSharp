using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.TArray
{
    class ArrayClass
    {
        /*
         * The Array class is the base class for all the arrays in C#. 
         * It is defined in the System namespace. 
         * The Array class provides various properties and methods to work with arrays.
         */

        void propertiesOfArrayClass()
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            /* IsFixedSize -> Gets a value indicating whether the Array has a fixed size */
            Console.WriteLine("Is Array FixedSize: {0}", list.IsFixedSize);

            /* IsReadOnly -> Gets a value indicating whether the Array is read-only */
            Console.WriteLine("Is Array ReadOnly: {0}", list.IsReadOnly);

            /* Length -> Gets a 32-bit integer that represents the total number of elements in all the dimensions of the Array */
            Console.WriteLine("Array Length: {0}", list.Length);

            /* LongLength -> Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array */
            Console.WriteLine("Array LongLength: {0}", list.LongLength);

            /* Rank -> Gets the rank (number of dimensions) of the Array */
            Console.WriteLine("Array Rank: {0}", list.Rank);
        }

        void methodsOfArrayClass()
        {
            {
                /* 
                    Clear(Array, Int32)
                    public static void Clear (Array array, int index, int length); 

                    Sets a range of elements in the Array to zero, to false, or to null, depending on the element type
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                Console.WriteLine("Array Length: {0}", list.Length);
                Array.Clear(list,0,list.Length);
                Console.WriteLine("Array Length: {0}", list.Length);
            }
            {
                /* 
                    Copy(Array, Array, Int32)
                    public static void Copy (Array sourceArray, Array destinationArray, long length); 

                    Copies a range of elements from an Array starting at the first element and 
                    pastes them into another Array starting at the first element. The length is specified as a 32-bit integer                    
                */
                int[] list1 = { 34, 72, 13, 44, 25, 30, 10 };
                int[] list2 = new int[7];
                Console.WriteLine("Array Length: {0}", list1.Length);
                Console.WriteLine("Array Length: {0}", list2.Length);
                Array.Copy(list1, list2, list1.Length);
                Console.WriteLine("Array Length: {0}", list2.Length);
            }
            {
                /* 
                    CopyTo(Array, Int32)
                    public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)

                    Copies all the elements of the current one-dimensional Array to the specified one-dimensional Array starting at the specified destination Array index. 
                    The index is specified as a 32-bit integer.                  
                */
                int[] list1 = { 34, 72, 13, 44, 25, 30, 10 };
                int[] list2 = new int[7];
                Console.WriteLine("Array Length: {0}", list1.Length);
                Console.WriteLine("Array Length: {0}", list2.Length);
                list1.CopyTo(list2, list1.Length);
                Console.WriteLine("Array Length: {0}", list2.Length);
            }
            {
                /* 
                    GetLength()
                    public int GetLength (int dimension);
                    Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.

                    GetLongLength()
                    public long GetLongLength (int dimension);
                    Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.                
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                Console.WriteLine("Array Length: {0}", list.GetLength(1));
                Console.WriteLine("Array Long Length: {0}", list.GetLongLength(1));
            }
            {
                /*
                    GetLowerBound()
                    public int GetLowerBound (int dimension);
                    Gets the lower bound of the specified dimension in the Array

                    GetUpperBound()
                    public int GetUpperBound (int dimension);
                    Gets the upper bound of the specified dimension in the Array
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                Console.WriteLine("Array Lower Bound: {0}", list.GetLowerBound(1));
                Console.WriteLine("Array Upper Bound: {0}", list.GetUpperBound(1));

            }
            {
                /*
                    GetType()
                    public Type GetType ();
                    Gets the Type of the current instance. (Inherited from Object.)
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                Console.WriteLine("Array Type: {0}", list.GetType());
            }
            {
                /*
                    GetValue(Int32)
                    public object? GetValue (int index);
                    Gets the value at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer
                    
                    SetValue(Object, Int32)
                    public void SetValue (object? value, int index);
                    Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                Console.WriteLine("Array value at 3rd index : {0}", list.GetValue(2));
                list.SetValue(3, 5);
                Console.WriteLine("Array value at 4th index : {0}", list.GetValue(3));
            }
            {
                /*
                    IndexOf(Array, Object)
                    public static int IndexOf (Array array, object? value);
                    Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional Array.

                    if value is not found then -1 is returned
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                int value = 13;
                int result = Array.IndexOf(list, value);
                if (result != -1)
                {
                    Console.WriteLine("Value {0} Found at {1}", value, result);
                } 
                else
                {
                    Console.WriteLine("Value {0} Not found", value);
                }
            }
            {
                /*
                    Reverse(Array)
                    public static void Reverse (Array array, int index, int length);
                    Reverses the sequence of the elements in the entire one-dimensional Array
                    It does in place reverse
                */
                int[] list = { 34, 72, 13, 44, 25, 30, 10 };
                Array.Reverse(list);        // reverse entire array
                Array.Reverse(list, 0, 5);        // reverse 5 elements from 0th index
            }
            {
                /*
                    sort(Array)
                    public static void Sort (Array keys, Array? items, int index, int length, System.Collections.IComparer? comparer);
                    Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array.
                    It does in place sort
                */
                // Creates and initializes a new Array and a new custom comparer.
                String[] myKeys = { "red", "GREEN", "YELLOW", "BLUE", "purple", "black", "orange" };
                String[] myValues = { "strawberries", "PEARS", "LIMES", "BERRIES", "grapes", "olives", "cantaloupe" };
                IComparer myComparer = new myReverserClass();

                // Displays the values of the Array.
                Console.WriteLine("The Array initially contains the following values:");
                PrintKeysAndValues(myKeys, myValues);

                // Sorts a section of the Array using the default comparer.
                Array.Sort(myKeys, myValues, 1, 3);
                Console.WriteLine("After sorting a section of the Array using the default comparer:");
                PrintKeysAndValues(myKeys, myValues);

                // Sorts a section of the Array using the reverse case-insensitive comparer.
                Array.Sort(myKeys, myValues, 1, 3, myComparer);
                Console.WriteLine("After sorting a section of the Array using the reverse case-insensitive comparer:");
                PrintKeysAndValues(myKeys, myValues);

                // Sorts the entire Array using the default comparer.
                Array.Sort(myKeys, myValues);
                Console.WriteLine("After sorting the entire Array using the default comparer:");
                PrintKeysAndValues(myKeys, myValues);

                // Sorts the entire Array using the reverse case-insensitive comparer.
                Array.Sort(myKeys, myValues, myComparer);
                Console.WriteLine("After sorting the entire Array using the reverse case-insensitive comparer:");
                PrintKeysAndValues(myKeys, myValues);
            }
            {
                /*
                    ToString()
                    public override string ToString ();
                    Returns a string that represents the current object. (Inherited from Object.)
                */
                /*
                Array myArray = new Array(Types::Integer);
                // Add some values to the array. 
                for (int i = 1; i < 10; i++)
                {
                    myArray.value(i, i * 2);
                }
                // Print out the values in the array. 
                print myArray.toString();
                */
            }
        }
        public static void PrintKeysAndValues(String[] myKeys, String[] myValues)
        {
            for (int i = 0; i < myKeys.Length; i++)
            {
                Console.WriteLine("  {0,-10}: {1}", myKeys[i], myValues[i]);
            }
            Console.WriteLine();
        }
        public static void Example()
        {
            ArrayClass obj = new ArrayClass();
            obj.propertiesOfArrayClass();
            obj.methodsOfArrayClass();
        }
    }
}
