using System;
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
    }
}
