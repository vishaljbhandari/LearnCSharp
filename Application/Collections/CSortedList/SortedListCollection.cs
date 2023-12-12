using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CArrayList
{
    class StackCollection
    {
        /*
         * The SortedList class 
         * a collection of key-and-value pairs that are sorted by the keys and are accessible by key and by index.
         * 
         * A sorted list is a combination of an array and a hash table
         * It contains a list of items that can be accessed using a key or an index
         * If you access items using an index, it is an ArrayList, 
         * if you access items using a key, it is a Hashtable
         * The collection of items is always sorted by the key value.
         */

        public static void Example()
        {
            StackProperties.Example();
            SortedListMethods.Example();
        }
    }
}
