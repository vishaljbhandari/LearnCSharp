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
        public static void Example()
        {
            ArrayMultiDimensional obj = new ArrayMultiDimensional();
            obj.twoDimensionArray();
            obj.threeDimensionArray();

        }
    }
}
