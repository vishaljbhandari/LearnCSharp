using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CBitArray
{
    class BitArrayCollection
    {
        /*
         * The BitArray class 
         * It represents a first-in, first out collection of object
         * 
         * enqueue Item -> adding an item in the list at front
         * deque Item -> removing element from rear
         */

        public static void Example()
        {
            BitArrayProperties.Example();
            BitArrayMethods.Example();
        }
    }
}
