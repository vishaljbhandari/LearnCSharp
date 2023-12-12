using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CArrayList
{
    class SortedListProperties
    {
        void propertyCapacity()
        {
            /* Capacity -> Gets or sets the number of elements that the SortedList*/

            SortedList sl = new SortedList();

            Console.WriteLine("Capacity: {0} beforing adding", sl.Capacity);
            sl.Add(1, 45);
            sl.Add(2, 78);
            Console.WriteLine("Capacity: {0} after adding", sl.Capacity);
            Console.WriteLine("Capacity: {0} ", sl.Capacity);
            Console.WriteLine("Count: {0}", sl.Count);
            CollectionHelper.PrintSortedList(sl);
        }
        void propertyCount()
        {
            /* Count -> Gets the number of elements actually contained in the SortedList */

            SortedList sl = new SortedList();

            Console.WriteLine("Count: {0} beforing adding", sl.Count);
            sl.Add(1, 45);
            sl.Add(2, 78);
            Console.WriteLine("Count: {0} after adding", sl.Count);
            Console.WriteLine("Capacity: {0} ", sl.Capacity);
            CollectionHelper.PrintSortedList(sl);
        }
        void propertyIsFixedSize()
        {
            /* IsFixedSize -> Gets a value indicating whether the ArrayList has a fixed size */

            SortedList sl = new SortedList();

            Console.WriteLine("IsFixedSize: {0} ", sl.IsFixedSize);
            sl.Add(1, 45);
            sl.Add(2, 78);
            Console.WriteLine("IsFixedSize: {0} ", sl.IsFixedSize);
            CollectionHelper.PrintSortedList(sl);
        }
        void propertyIsReadOnly()
        {
            /* IsReadOnly -> Gets a value indicating whether the ArrayList is read-only */

            SortedList sl = new SortedList();

            Console.WriteLine("IsReadOnly: {0} ", sl.IsReadOnly);
            sl.Add(1, 45);
            sl.Add(2, 78);
            Console.WriteLine("IsReadOnly: {0} ", sl.IsReadOnly);
            CollectionHelper.PrintSortedList(sl);
        }
        void propertyItem()
        {
            /* Item -> Gets or sets the element at the specified index */




        }
        void propertyKey()
        {
            /* Keys -> Gets the keys in the SortedList. */
            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            // get a collection of the keys. 
            ICollection keys = sl.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine(key + ": " + sl[key]);
            }
        }
        void propertyValue()
        {
            /* Values -> Gets the values in the SortedList. */
            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            // get a collection of the values. 
            ICollection values = sl.Values;

            foreach (string value in values)
            {
                Console.WriteLine(value + ": " + sl[value]);
            }
        }
        public static void Example()
        {
            SortedListProperties obj = new SortedListProperties();
            {
                obj.propertyCapacity();
                obj.propertyCount();
                obj.propertyIsFixedSize();
                obj.propertyIsReadOnly();
                obj.propertyItem();
                obj.propertyKey();
                obj.propertyValue();
            }

        }
    }
}
