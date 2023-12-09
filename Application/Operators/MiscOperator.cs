using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Operators
{
    class MiscOperator
    {
        public static void Example()
        {
            int a = 16;
            int b = 60;
            int c;


            // sizeof()	Returns the size of a data type
            a = sizeof(int);
            Console.WriteLine("a = sizeof(int) = {0}", sizeof(int));

            // typeof()	Returns the type of a class
            Type typ = typeof(int);
            Console.WriteLine("typ = typeof(int) = {0}", typeof(int));

            unsafe
            {
                // &	Returns the address of an variable.
                int* ptr = &b;
                // Console.WriteLine("ptr = &b = {0}", ptr);
            }
            unsafe
            {
                // *	Pointer to a variable.
                int* ptr = &a;
                int val = *ptr;     // c = *a
                Console.WriteLine("val = *ptr = {0}", val);
            }

            // ? :	Conditional Expression	If Condition is true ? Then value X : Otherwise value Y
            int myvalue = a == b ? 0 : 1;
            Console.WriteLine("myvalue = a == b ? 0 : 1 = {0}", myvalue);

            // is	Determines whether an object is of a certain type.
            if(a is int)
            {
                Console.WriteLine("a is int");
            }

            // as	Cast without raising an exception if the cast fails.
            Object obj = new StringReader("Hello");
            StringReader r = obj as StringReader;
            Console.WriteLine("a = {0}, b = {1}, c %= a = {2}", a, b, c);
        }
    }
}
