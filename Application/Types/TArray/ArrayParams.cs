using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CArray
{
    class ArrayParams
    {
        /*
         * Param Array
         * is used when while decalring array, number of arguments are to be passed are not known
         * 
         */
        public int AddElements(params int[] arr)        // accepting arguments as param array
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public static void Example()
        {
            ArrayParams obj = new ArrayParams();
            int sum1 = obj.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("The sum1 is: {0}", sum1);
            int sum2 = obj.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("The sum2 is: {0}", sum2);
        }
    }
}
