using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.UnsafeCode
{
    class UnsafeCode
    {
        /*
         * C# allows using pointer variables in a function of code block when it is marked by the unsafe modifier.
         * The unsafe code or the unmanaged code is a code block that uses a pointer variable.
         */

        /*
         *  To execute the unsafe code, please set compilation option in Project >> Compile Options >> Compilation Command to

            mcs *.cs -out:main.exe -unsafe"
         * 
         */
        void compilingUnSafeCode()
        {
            /* For compiling unsafe code, you have to specify the /unsafe command-line switch with command-line compiler. 
                csc /unsafe prog1.cs
             */
            /* For Visual Studio IDE (enable use of unsafe code in the project properties)
                    Open project properties by double clicking the properties node in the Solution Explorer.
                    Click on the Build tab.
                    Select the option "Allow unsafe code".
             */
        }

        unsafe void declaringEntireMethodUnsafe()
        {
            /* We can declare entire method as unsafe, add "unsafe" keyword before the function defination */
            int var = 20;
            int* p = &var;

            Console.WriteLine("Data is: {0} ", var);
            Console.WriteLine("Address is: {0}", (int)p);
        }

        void declaringPartUnsafe()
        {
            /* Instead of declaring an entire method as unsafe, you can also declare a part of the code as unsafe. */
            unsafe
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Address is: {0}", (int)p);
            }
        }
        public static void Example()
        {
            UnsafeCode obj = new UnsafeCode();
            obj.declaringEntireMethodUnsafe();
            obj.declaringPartUnsafe();
        }
    }
}
