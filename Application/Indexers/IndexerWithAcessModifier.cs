using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Indexers
{
    /*
     * You can also specify different access levels for the get and set accessors of an indexer using access modifiers.
     * 
     * the set accessor is private, so the indexer value can only be set within the class
     * the get accessor is private, so the indexer value can only be get within the class
     */

    class MyCollection
    {
        private string[] items = new string[3] { "One", "Two", "Three" };

        public string this[int index]
        {
            get { return items[index]; }
            private set { items[index] = value; }
        }

        public void UpdateItem(int index, string newValue)
        {
            this[index] = newValue;
        }
    }
    class IndexerWithAcessModifier
    {
        public static void Example()
        {
            MyCollection col = new MyCollection();

            Console.WriteLine("Before: " + col[1]);
            col.UpdateItem(1, "Updated");
            Console.WriteLine("After: " + col[1]);
        }
    }
}
