using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CBitArray
{
    class BitArrayProperties
    {
        void propertyCount()
        {
            /* Count -> Gets the number of elements contained in the BitArray */
            // Creating bit array of 8 bytes
            BitArray bitArray = new BitArray(8);
            // create array of 8 bytes
            byte[] bData = { 60 };

            Console.WriteLine("Count: {0} before bitArray", bitArray.Count);
            // storing value into bit array
            bitArray = new BitArray(bData);
            Console.WriteLine("Count: {0} before bitArray", bitArray.Count);
            CollectionHelper.PrintBitArray(bitArray);
        }
        void propertyLength()
        {
            /* Length -> Gets or sets the number of elements in the BitArray. */

            // Creating bit array of 8 bytes
            BitArray bitArray = new BitArray(8);
            // create array of 8 bytes
            byte[] bData = { 60 };

            Console.WriteLine("Length: {0} before storing", bitArray.Length);
            Console.WriteLine("Count: {0} before storing", bitArray.Count);
            // storing value into bit array
            bitArray = new BitArray(bData);
            Console.WriteLine("Length: {0} after storing", bitArray.Length);
            Console.WriteLine("Count: {0} after storing", bitArray.Count);
            CollectionHelper.PrintBitArray(bitArray);
        }

        void propertyIsReadOnly()
        {
            /* IsReadOnly -> Gets a value indicating whether the BitArray is read-only */


            // Creating bit array of 8 bytes
            BitArray bitArray = new BitArray(8);
            // create array of 8 bytes
            byte[] bData = { 60 };

            // storing value into bit array
            bitArray = new BitArray(bData);
            Console.WriteLine("IsReadOnly: {0} ", bitArray.IsReadOnly);
        }
        void propertyItem()
        {
            /* Item -> Gets or sets the value of the bit at a specific position in the BitArray. */




        }
        public static void Example()
        {
            BitArrayProperties obj = new BitArrayProperties();
            {
                obj.propertyLength();
                obj.propertyCount();
                obj.propertyIsReadOnly();
                obj.propertyItem();
            }

        }
    }
}
