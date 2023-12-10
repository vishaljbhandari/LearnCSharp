using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.TArray
{
    class ArrayIteration
    {
        /* Array elements can be accessed using loop iterations */
        void usingForLoop()
        {
            int[] arr = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                arr[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, arr[j]);
            }
        }

        void usingForEach()
        {
            int[] arr = new int[10]; /* n is an array of 10 integers */

            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 100;
            }

            /* output each array element's value */
            foreach (int j in arr)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }
        public static void Example()
        {
            ArrayIteration obj = new ArrayIteration();
            obj.usingForLoop();
            obj.usingForEach();
        }
    }
}
