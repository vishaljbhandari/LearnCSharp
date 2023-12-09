using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.PointerType
{
    class CPointerType
    {
        /*
         * Pointer type variables store the memory address of another type
         * Pointers in C# have the same capabilities as the pointers in C or C++
         */

        /*
         * Syntax for declaring a pointer type is
         
           type* identifier;
        */
        public static void Example()
        {
            unsafe
            {
                {
                    int value = 5;
                    int* iptr = &value;
                }
                {
                    char value = 'A';
                    char* cptr = &value;
                }
            }
        }
    }
}
