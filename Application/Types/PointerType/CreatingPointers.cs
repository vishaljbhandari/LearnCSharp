using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.PointerType
{
    class CreatingPointers  /* Declaring & Initializing */
    {
        /*
         * Syntax for declaring a pointer type is
         
           type* identifier;
        */
        void pointerDeclarations()
        {
            /*
             * A pointer is a variable whose value is the address of another variable (direct address of the memory location)
             * 
             * 
             * The general form of a pointer declaration is −
             *  type *var-name;
             * 
            */
            unsafe
            {

#pragma warning disable CS0168 // Variable is declared but never used
                int* ip;    /* pointer to an integer */
                double* dp;    /* pointer to a double */
                float* fp;    /* pointer to a float */
                char* ch;     /* pointer to a character */
#pragma warning restore CS0168 // Variable is declared but never used
            }
            unsafe
            {
                int var = 20;
                int* ptr = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Address is: {0}", (int)ptr);
            }
        }
        public static void Example()
        {
            CreatingPointers obj = new CreatingPointers();
            obj.pointerDeclarations();
        }
    }
}
