using System;

namespace UnsafeCode
{
    class ArrayElementUsingPointer
    {
        /*
        In C#, an array name and a pointer to a data type same as the array data, are not the same variable type. 
        For example, int *p and int[] p, are not same type. 
        
        You can increment the pointer variable p because it is not fixed in memory but an array address is fixed in memory, and you can't increment that.

        Therefore, if you need to access an array data using a pointer variable, as we traditionally do in C, or C++ (please check: C Pointers), 
        you need to fix the pointer using the fixed keyword.
        */
        public unsafe static void Run()     // this block contains unsafe code - unsafe keyword
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }

            Console.ReadKey();
        }
    }
}