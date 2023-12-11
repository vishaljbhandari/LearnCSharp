using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CArray
{
    class ArrayJagged
    {
        /*
         * A Jagged array is an array of arrays
         */
        void declaringJaggedArray()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            int[][] scores;     // only declaring
#pragma warning restore CS0168 // Variable is declared but never used
        }
        void initializingJaggedArray()
        {
            int[][] scores = new int[5][];     // declaring with initialization

            int[][] marks = new int[2][] { 
                new int[] { 92, 93, 94 }, 
                new int[] { 85, 66, 87, 88 } 
            };
            int[][] result = new int[][]{
                new int[]{ 0, 0},
                new int[]{ 1, 2},
                new int[]{ 2, 4},
                new int[]{ 3, 6}, 
                new int[]{ 4, 8} 
            };
        }
        void accessingJaggedArray()
        {
            int[][] result = new int[][]{
                new int[]{ 0, 0},
                new int[]{ 1, 2},
                new int[]{ 2, 4},
                new int[]{ 3, 6},
                new int[]{ 4, 8}
            };
            /* output each array element's value */
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, result[i][j]);
                }
            }
        }
        public static void Example()
        {
            ArrayJagged obj = new ArrayJagged();
            obj.declaringJaggedArray();
            obj.initializingJaggedArray();
            obj.accessingJaggedArray();
        }
    }
}
