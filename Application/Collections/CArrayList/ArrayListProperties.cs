using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CArrayList
{
    class ArrayListProperties
    {
        void propertyCapacity()
        {
            /* Capacity -> Gets or sets the number of elements that the ArrayList can contain */

            System.Collections.ArrayList al = new System.Collections.ArrayList();

            Console.WriteLine("Capacity: {0} beforing adding", al.Capacity);
            al.Add(45);
            al.Add(78);
            Console.WriteLine("Capacity: {0} after adding", al.Capacity);
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
            CollectionHelper.PrintArrayList(al);
        }
        void propertyCount()
        {
            /* Count -> Gets the number of elements actually contained in the ArrayList */

            System.Collections.ArrayList al = new System.Collections.ArrayList();

            Console.WriteLine("Count: {0} beforing adding", al.Count);
            al.Add(45);
            al.Add(78);
            Console.WriteLine("Count: {0} after adding", al.Count);
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            CollectionHelper.PrintArrayList(al);
        }
        void propertyIsFixedSize()
        {
            /* IsFixedSize -> Gets a value indicating whether the ArrayList has a fixed size */

            System.Collections.ArrayList al = new System.Collections.ArrayList();

            Console.WriteLine("IsFixedSize: {0} ", al.IsFixedSize);
            al.Add(45);
            al.Add(78);
            Console.WriteLine("IsFixedSize: {0} ", al.IsFixedSize);
            CollectionHelper.PrintArrayList(al);
        }
        void propertyIsReadOnly()
        {
            /* IsReadOnly -> Gets a value indicating whether the ArrayList is read-only */

            System.Collections.ArrayList al = new System.Collections.ArrayList();

            Console.WriteLine("IsReadOnly: {0} ", al.IsReadOnly);
            al.Add(45);
            al.Add(78);
            Console.WriteLine("IsReadOnly: {0} ", al.IsReadOnly);
            CollectionHelper.PrintArrayList(al);
        }
        void propertyItem()
        {
            /* Item -> Gets or sets the element at the specified index */




        }
        public static void Example()
        {
            ArrayListProperties obj = new ArrayListProperties();
            {
                obj.propertyCapacity();
                obj.propertyCount();
                obj.propertyIsFixedSize();
                obj.propertyIsReadOnly();
                obj.propertyItem();
            }

        }
    }
}
