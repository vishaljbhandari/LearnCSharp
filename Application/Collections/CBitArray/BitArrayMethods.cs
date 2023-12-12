using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collections.CBitArray
{
    class BitArrayMethods
    {
        void methodBitwiseOperation()
        {
            /*
                public BitArray And(BitArray value);
                Performs the bitwise AND operation on the elements in the current BitArray against the corresponding elements in the specified BitArray.

                public BitArray Not();
                Inverts all the bit values in the current BitArray, so that elements set to true are changed to false, and elements set to false are changed to true.

                public BitArray Or(BitArray value);
                Performs the bitwise OR operation on the elements in the current BitArray against the corresponding elements in the specified BitArray.

                public BitArray Xor(BitArray value);
                Performs the bitwise eXclusive OR operation on the elements in the current BitArray against the corresponding elements in the specified BitArray.
             */
            BitArray bitArrayA = new BitArray(8);
            byte[] bDataA = { 60 };
            bitArrayA = new BitArray(bDataA);
            CollectionHelper.PrintBitArray(bitArrayA);

            BitArray bitArrayB = new BitArray(8);
            byte[] bDataB = { 20 };
            bitArrayB = new BitArray(bDataB);
            CollectionHelper.PrintBitArray(bitArrayB);

            BitArray bitArrayC = new BitArray(8);
            bitArrayC = bitArrayA.And(bitArrayB);
            Console.WriteLine("C = A AND B");
            CollectionHelper.PrintBitArray(bitArrayC);

            bitArrayC = bitArrayA.Or(bitArrayB);
            Console.WriteLine("C = A OR B");
            CollectionHelper.PrintBitArray(bitArrayC);

            bitArrayC = bitArrayA.Xor(bitArrayB);
            Console.WriteLine("C = A XOR B");
            CollectionHelper.PrintBitArray(bitArrayC);

            bitArrayC = bitArrayA.Not();
            Console.WriteLine("C = NOT A");
            CollectionHelper.PrintBitArray(bitArrayC);
        }
        void methodGetSet()
        {
            /* 
                public void Set(int index, bool value);
                Sets the bit at a specific position in the BitArray to the specified value.

                public void SetAll(bool value);
                Sets all bits in the BitArray to the specified value.

                public bool Get(int index);
                Gets the value of the bit at a specific position in the BitArray.
            */
            BitArray bitArrayA = new BitArray(8);
            byte[] bDataA = { 60 };
            bitArrayA = new BitArray(bDataA);
            CollectionHelper.PrintBitArray(bitArrayA);

            bitArrayA.SetAll(true);
            Console.WriteLine("A After setting All True");
            CollectionHelper.PrintBitArray(bitArrayA);

            // Sets the last index to false.
            bitArrayA.Set(bitArrayA.Count - 1, false);
            Console.WriteLine("A After setting Last Bit True");
            CollectionHelper.PrintBitArray(bitArrayA);

            Console.WriteLine("index {0} : {1}", bitArrayA.Count - 2, bitArrayA.Get(bitArrayA.Count - 2));
        }

        public static void Example()
        {
            BitArrayMethods obj = new BitArrayMethods();
            {
                obj.methodBitwiseOperation();
                obj.methodGetSet();
            }
        }
    }
}
