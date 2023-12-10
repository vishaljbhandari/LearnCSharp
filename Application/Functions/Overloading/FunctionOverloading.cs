using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Overloading
{
    class FunctionOverloading
    {
        /* multiple definitions for the same function name in the same scope */
        /*
         * The definition of the function 
         * must differ from each other by the types and/or the number of arguments in the argument list. 
         * You cannot overload function declarations that differ only by return type
         */

        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        public static void Example()
        {
            FunctionOverloading obj = new FunctionOverloading();

            // Call print to print integer
            obj.print(5);

            // Call print to print float
            obj.print(500.263);

            // Call print to print string
            obj.print("Hello C++");
        }
    }
}
