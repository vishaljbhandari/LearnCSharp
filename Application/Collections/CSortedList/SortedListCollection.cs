using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Application.Collections.CSortedList
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
            SortedListProperties.Example();
            SortedListMethods.Example();

            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.ReadKey();
        }
    }
}
