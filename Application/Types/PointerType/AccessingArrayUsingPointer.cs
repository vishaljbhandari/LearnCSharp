using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.PointerType
{
    class AccessingArrayUsingPointer
    {
        /* 
         * In C#, an array name and a pointer to a data type same as the array data, are not the same variable type
         *  
         *  int *p and int[] p, are not same type
         *  we can increment the pointer variable p because it is not fixed in memory
         *  but an array address is fixed in memory, so we can not increment
         *  
         *  access an array data using a pointer variable, we need to fix the pointer using the fixed keyword
         */
        unsafe void accessingArrayElement()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

            /* let us have array address in pointer */
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
            }
        }
        public static void Example()
        {

        }
    }
}
