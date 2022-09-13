using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PassingArrayToFunction
{
    class MyArray
    {
        double getAverage(int[] arr, int size)      // receiving array as argument
        {
            double avg;
            int sum = 0;

            for (int i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
        public static void Run()
        {
            MyArray app = new MyArray();

            /* an int array with 5 elements */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };

            /* pass pointer to the array as an argument */
            double avg = app.getAverage(balance, 5);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);
        }
    }
}

namespace ParamArrays
{
    // While declaring a method, you are not sure of the number of arguments passed as a parameter..
    class ParamArray
    {
        public int AddElements(params int[] arr)    // Accepts all arguments in parameter arrays "params" keyword
        {
            int sum = 0;
            Console.WriteLine("Number of Arguments - {0}", arr.Length);
            foreach (int i in arr)
            {
                Console.WriteLine("{0} ", i);
                sum += i;
            }
            return sum;
        }
    }
    class TestClass
    {
        public static void Run()
        {
            ParamArray app = new ParamArray();
            Console.WriteLine("The sum is: {0}", app.AddElements(512, 720, 250, 567, 889)); // passing 5 arguments to AddElements
            Console.WriteLine("The sum is: {0}", app.AddElements(512, 720, 250, 567));  // passing 4 arguments to AddElements
            Console.WriteLine("The sum is: {0}", app.AddElements(512, 720));  // passing 2 arguments to AddElements
        }
    }
}

namespace ArrayClass
{
    // The Array class is the base class for all the arrays in C#. It is defined in the System namespace.
    // The Array class provides various properties and methods to work with arrays.
    class MyArray
    {
        public static void Run()
        {
            Array array = new Array[5];    // Array Class

            // Properties of Array class
            Console.WriteLine("array.IsFixedSize {0}", array.IsFixedSize);  // is array fixed size
            Console.WriteLine("array.IsReadOnly {0}", array.IsReadOnly);    // is array readonly
            Console.WriteLine("array.IsSynchronized {0}", array.IsSynchronized);    // is array synchronized
            Console.WriteLine("array.Length {0}", array.Length); // total number of elements in all the dimensions of the Array.
            Console.WriteLine("array.LongLength {0}", array.LongLength); // total number of elements in all the dimensions of the Array
            Console.WriteLine("array.Rank {0}", array.Rank);    // tells number of dimensions of array

            int[] myArray = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("myArray.IsFixedSize {0}", myArray.IsFixedSize);  // is array fixed size
            Console.WriteLine("myArray.IsReadOnly {0}", myArray.IsReadOnly);    // is array readonly
            Console.WriteLine("myArray.IsSynchronized {0}", myArray.IsSynchronized);    // is array synchronized
            Console.WriteLine("myArray.Length {0}", myArray.Length); // total number of elements in all the dimensions of the Array.
            Console.WriteLine("myArray.LongLength {0}", myArray.LongLength); // total number of elements in all the dimensions of the Array
            Console.WriteLine("myArray.Rank {0}", myArray.Rank);    // tells number of dimensions of array


            // Methods of Array class
            int index = 1;
            int length = 2;
            int[] clearArray = { 34, 72, 13, 44, 25, 30, 10 };
            Array.Clear(clearArray, index, length); // clears array from 1st position for next two indexes

            Array secondArray = new Array[5];
            Array.Copy(array, secondArray, length);  // copies length elements from 1st position of array to 1st position of secondArray

            int[] thirdArray = { 34, 72, 13, 44, 25, 30, 10 };
            int[] fourthArray = new int[10];
            thirdArray.CopyTo(fourthArray, 1);  // copies length elements from 1st position of array to 1st position of secondArray



            int arrayLength = array.Length; // get length of array
            long longArrayLength = array.LongLength;

            Console.WriteLine("GetLowerBound {0}", array.GetLowerBound(0)); // Gets the lower bound of the specified dimension in the Array. 0 fir 1st dimension, 1 for 2nd dimension .. so on
            Console.WriteLine("GetUpperBound {0}", array.GetUpperBound(0)); // Gets the upper bound of the specified dimension in the Array. 0 fir 1st dimension, 1 for 2nd dimension.. so on

            Console.WriteLine("GetType {0}", array.GetType()); // Gets the Type of the current instance. (Inherited from Object)

            Console.WriteLine("GetValue {0}", array.GetValue(1)); // Gets the value at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.

            Array.Reverse(myArray); // reversing array

            Array.Sort(myArray);   // sorting array

            int value = Array.IndexOf(myArray, 2);    // Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional Array.

            Console.WriteLine(myArray.GetValue(0));    // Gets the value at the specified position in the one-dimensional Array 

            myArray.SetValue(5, 2);   // Sets a value to the element at the specified position in the one-dimensional Array

            // 2d array
            Array arr = Array.CreateInstance(typeof(String), 3, 6);
            // Array.CreateInstance(Type, length); // creating one D array
            // Array.CreateInstance(Type, length-i, length-j); // creating 2D array

            arr.SetValue("One", 0, 0);
            arr.SetValue("Two", 0, 1);
            arr.SetValue("Three", 0, 2);
            arr.SetValue("Four", 0, 3);
            arr.SetValue("Five", 1, 4);
            arr.SetValue("Six", 1, 5);
            arr.SetValue("Seven", 1, 2);
            arr.SetValue("Eight", 1, 3);
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            // Getting values
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine(arr.GetValue(i, j));
                    // Console.WriteLine(arr.GetValue(i)[j]); // can not be used
                    // Console.WriteLine(arr[i].GetValue(j)); // can not be used
                }

        }
    }
}

namespace Arrays
{
    class Program
    {
        public static void TwoDimensionalArrays()
        {
            int[,,] m;  // 3 d array declaration
            string[,] names; // 2 d array declaration without initialization

            // 2 d array declaration with initialization
            int[,] a = new int[3, 4] {
               {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
               {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
               {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
            };

            int val = a[2, 3];  // accessing values

            /* an array with 5 rows and 2 columns*/
            int[,] arr = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++) {
                    Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
                }
            }
        }

        public static void JaggedArray()
        {
            int[][] scores; // A Jagged array is an array of arrays

            int[][] jscores = new int[5][];
            for (int k = 0; k < jscores.Length; k++)
            {
                jscores[k] = new int[4];
            }

            scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };   // initialization 2nd order of jagged array 
            // score[0] has 3 values 92,93,94
            // score[1] has 4 values 85, 66, 87, 88

            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
        }

        int[][] scores = new int[2][]{new int[]{92,93,94},new int[]{85,66,87,88}};

        static void Main(string[] args)
        {
            // datatype[] arrayName;

            // Declaring Arrays
            double[] myFirstArray;       

            // Initializing an Array using new opeartor and [] braces
            double[] mySecondArray = new double[10];    // create array of size 10 (10 elements)

            // Assigning Values to an Array

            // You can assign values to individual array elements, by using the index number, like −

            double[] myThirdArray = new double[10];
            myThirdArray[0] = 4500.0;   // accessing first element using subscript, index starts from ZERO

            // You can assign values to the array at the time of declaration, as shown −
            double[] myForthArray = { 2340.0, 4523.69, 3421.0 };

            // You can also create and initialize an array, as shown −
            int[] myFifthArray = new int[5] { 99, 98, 92, 97, 95 };     // number of element must be equal to size

            // You can also create and initialize an array, as shown −
            // int[] myNewArray = new int[2] { 99, 98, 92, 97, 95 };    // error, number of elements must be equal to size 
            // int[] myNewArray = new int[40] { 99, 98, 92, 97, 95 };   // error, number of elements must be equal to size 

            // You may also omit the size of the array, as shown −
            int[] mySixthArray = new int[] { 99, 98, 92, 97, 95 };  // size it will automatically consider

            // You can copy an array variable into another target array variable.In such case, both the target and source point to the same memory location −
            int[] mySeventhArray = new int[] { 99, 98, 92, 97, 95 };
            int[] myEigthArray = mySeventhArray;    // is it shallow copy // both variables point to same location

            // When you create an array, C# compiler implicitly initializes each array element to a default value depending on the array type. 
            // For example, for an int array all elements are initialized to 0.

            {
                int[] n = new int[10]; /* n is an array of 10 integers */
                int i, j;

                /* initialize elements of array n */
                for (i = 0; i < 10; i++)
                {
                    n[i] = i + 100;
                }

                /* output each array element's value */
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
                }


                /* output each array element's value */
                foreach (int k in n)
                {
                    int l = k - 100;
                    Console.WriteLine("Element[{0}] = {1}", l, k);
                }
            }
            TwoDimensionalArrays();
            JaggedArray();
            PassingArrayToFunction.MyArray.Run();
            ParamArrays.TestClass.Run();
            ArrayClass.MyArray.Run();
            Console.ReadLine();
        }
    }
}
