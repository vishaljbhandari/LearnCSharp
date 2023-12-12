using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CHashTable
{
    class HashTableProperties
    {
        void propertyCount()
        {
            /* Count -> Gets the number of key-and-value pairs contained in the Hashtable */

            Hashtable hashtable = new Hashtable();

            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            hashtable.Add("004", "Mausam Benazir Nur");
            hashtable.Add("005", "M. Amlan");
            hashtable.Add("006", "M. Arif");
            hashtable.Add("007", "Ritesh Saikia");

            Console.WriteLine("Count: {0} after adding", hashtable.Count);
            CollectionHelper.PrintHashTable(hashtable);
        }
        void propertyIsFixedSize()
        {
            /* IsFixedSize -> Gets a value indicating whether the Hashtable has a fixed size. */

            Hashtable hashtable = new Hashtable();

            Console.WriteLine("IsFixedSize: {0} ", hashtable.IsFixedSize);
            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            Console.WriteLine("IsFixedSize: {0} ", hashtable.IsFixedSize);
            CollectionHelper.PrintHashTable(hashtable);
        }
        void propertyIsReadOnly()
        {
            /* IsReadOnly -> Gets a value indicating whether the Hashtable is read-only. */

            Hashtable hashtable = new Hashtable();

            Console.WriteLine("IsFixedSize: {0} ", hashtable.IsReadOnly);
            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            Console.WriteLine("IsFixedSize: {0} ", hashtable.IsReadOnly);
            CollectionHelper.PrintHashTable(hashtable);
        }
        void propertyItem()
        {
            /* Item -> Gets or sets the value associated with the specified key. */
        }
        void propertyKeysValues()
        {
            /*
                Keys
                Gets an ICollection containing the keys in the Hashtable.

                Values
                Gets an ICollection containing the values in the Hashtable. 
            */
            Hashtable hashtable = new Hashtable();

            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            hashtable.Add("004", "Mausam Benazir Nur");
            hashtable.Add("005", "M. Amlan");
            hashtable.Add("006", "M. Arif");
            hashtable.Add("007", "Ritesh Saikia");

            Console.WriteLine("Count: {0} after adding", hashtable.Count);
            CollectionHelper.PrintHashTable(hashtable);

            ICollection keys = hashtable.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key + ": " + hashtable[key]);
            }

            ICollection values = hashtable.Values;
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }
        public static void Example()
        {
            HashTableProperties obj = new HashTableProperties();
            {
                obj.propertyCount();
                obj.propertyIsFixedSize();
                obj.propertyIsReadOnly();
                obj.propertyItem();
                obj.propertyKeysValues();
            }

        }
    }
}
