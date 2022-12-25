using System;

namespace UnsafeCode
{
    class PointerAsParameter
    {
        //Passing Pointers as Parameters to Methods
        public unsafe void swap(int* p, int* q)     // this block contains unsafe code - unsafe keyword
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
        public unsafe static void Run()     // this block contains unsafe code - unsafe keyword
        {
            PointerAsParameter p = new PointerAsParameter();
            int var1 = 10;
            int var2 = 20;
            int* x = &var1;
            int* y = &var2;

            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
            p.swap(x, y);
            Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);

            Console.ReadKey();
        }
    }
}