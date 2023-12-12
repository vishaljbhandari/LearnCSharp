using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CHashTable
{
    class HashTableMethods
    {
        void methodAdding()
        {
            /* 	
                public virtual void Add(object key, object value);
                Adds an element with the specified key and value into the Hashtable.
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
        }

        void methodSorting()
        {
            /* Sorting not required */
        }
        void methodClear()
        {
            /* 
                public virtual void Clear();
                Removes all elements from the Hashtable.
            */
            Hashtable hashtable = new Hashtable();

            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            hashtable.Add("004", "Mausam Benazir Nur");
            hashtable.Add("005", "M. Amlan");
            hashtable.Add("006", "M. Arif");
            hashtable.Add("007", "Ritesh Saikia");
            hashtable.Clear();
            Console.WriteLine("Count: {0} after clearing", hashtable.Count);
            CollectionHelper.PrintHashTable(hashtable);
        }

        void methodRemoving()
        {
            /* 
                public virtual void Remove(object key);
                Removes the element with the specified key from the Hashtable.
            */
            Hashtable hashtable = new Hashtable();

            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            hashtable.Add("004", "Mausam Benazir Nur");
            hashtable.Add("005", "M. Amlan");
            hashtable.Add("006", "M. Arif");
            hashtable.Add("007", "Ritesh Saikia");
            hashtable.Remove("007");
            Console.WriteLine("Count: {0} after removing", hashtable.Count);
            CollectionHelper.PrintHashTable(hashtable);
        }

        void methodSearching()
        {
            /*
                public virtual bool ContainsKey(object key);
                Determines whether the Hashtable contains a specific key.

                public virtual bool ContainsValue(object value);
                Determines whether the Hashtable contains a specific value.
             */
            Hashtable hashtable = new Hashtable();

            hashtable.Add("001", "Zara Ali");
            hashtable.Add("002", "Abida Rehman");
            hashtable.Add("003", "Joe Holzner");
            hashtable.Add("004", "Mausam Benazir Nur");
            hashtable.Add("005", "M. Amlan");
            hashtable.Add("006", "M. Arif");
            hashtable.Add("007", "Ritesh Saikia");
            CollectionHelper.PrintHashTable(hashtable);
            if (hashtable.ContainsKey("005"))
            {
                Console.WriteLine("Key found");
            }
            if (hashtable.ContainsValue("Joe Holzner"))
            {
                Console.WriteLine("Value found");
            }
        }

        public static void Example()
        {
            HashTableMethods obj = new HashTableMethods();
            {
                obj.methodAdding();
                obj.methodSorting();
                obj.methodClear();
                obj.methodRemoving();
                obj.methodSearching();
            }
        }
    }
}
