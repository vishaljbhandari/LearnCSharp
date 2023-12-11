using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CArray
{
    class ArrayWithFunction
    {
        /* You can pass an array as a function argument in C# */
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
        void passingToFunction()
        {
            /* an int array with 5 elements */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };

            /* pass pointer to the array as an argument */
            double avg = getAverage(balance, 5);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);
        }

        public static void Example()
        {
            ArrayWithFunction obj = new ArrayWithFunction();
            obj.passingToFunction();
        }
    }
}
