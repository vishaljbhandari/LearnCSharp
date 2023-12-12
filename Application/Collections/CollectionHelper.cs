using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections
{
    public class CollectionHelper
    {
        public static void PrintArrayList(System.Collections.ArrayList arrayList)
        {
            foreach (int item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        public static void PrintSortedList(System.Collections.SortedList sortedList)
        {
            foreach (int item in sortedList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        public static void PrintStack(System.Collections.Stack stack)
        {
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        public static void PrintQueue(System.Collections.Queue queue)
        {
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        public static void PrintBitArray(System.Collections.BitArray bitArray)
        {
            foreach (int item in bitArray)
            {
                Console.Write("{0, -6} ", item);
            }
            Console.Write("\n");
        }
        public static void PrintHashTable(System.Collections.Hashtable hashtable)
        {
            ICollection keys = hashtable.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine(key + ": " + hashtable[key]);
            }
        }
    }
}
