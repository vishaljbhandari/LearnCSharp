using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CArray
{
    class ArrayMultiDimensional
    {
        /*
         * C# supports multidimensional arrays. 
         * The simplest form of the multidimensional array is the two-dimensional array
         * Multi-dimensional arrays are also called rectangular array
         * 
         */
        void twoDimensionArray()
        {
            /*
             * Two-Dimensional Arrays
             * simplest form of the multidimensional array
             * a list of one-dimensional arrays
             * every element in the array a is identified by an element name of the form a[ i , j ] using two subscripts
             */
            /* declaration & initialization*/
            int[,] arr = new int[3, 4] {
               {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
               {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
               {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
            };
            /* accessing/writing 2d array element using subscript -> row index, column index*/
            int val = arr[2, 3];

            /* outputing/reading each array element's value */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, arr[i, j]);
                }
            }
        }
        void threeDimensionArray()
        {
            /*
             * Three-Dimensional Arrays
             * a list of two-dimensional arrays
             * every element in the array a is identified by an element name of the form a[ i , j , k ] using three subscripts
             */
            /* declaration & initialization */
            int[,,] arr = new int[2, 3, 4] {
                {
                   {0, 1, 2, 3} ,
                   {4, 5, 6, 7} ,
                   {8, 9, 10, 11}
                },
                {
                   {0, 1, 2, 3} ,
                   {4, 5, 6, 7} ,
                   {8, 9, 10, 11}
                }
            };
            /* accessing/writing 3d array element using subscript -> row index, column index, depth index*/
            int val = arr[2, 3, 1];

            /* outputing/reading each array element's value */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, arr[i, j, k]);
                    }
                }
            }
        }

        public static void TwoDimensionalArrays()
        {
#pragma warning disable 168 // supressing warning CS0168
            int[,,] m;  // 3 d array declaration
            string[,] names; // 2 d array declaration without initialization
#pragma warning restore 168 // restoring warning CS0168


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
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
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

        int[][] scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };

        public static void Example()
        {
            ArrayMultiDimensional obj = new ArrayMultiDimensional();
            obj.twoDimensionArray();
            obj.threeDimensionArray();

            // datatype[] arrayName;

            // Declaring Arrays
#pragma warning disable 168 // supressing warning CS0168
            double[] myFirstArray;
#pragma warning restore 168 // restoring warning CS0168

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
        }
    }
}
