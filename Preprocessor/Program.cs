#define PI      // #define symbol

#define PIE     // define PIE
#undef PIE      // undefine PIE

#define DEBUG
#define VC_V10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// The preprocessor directives give instruction to the compiler to preprocess the information before actual compilation starts.
// All preprocessor directives begin with #, and only white-space characters may appear before a preprocessor directive on a line. 
// Preprocessor directives are not statements, so they do not end with a semicolon (;).
// C# compiler does not have a separate preprocessor; however, the directives are processed as if there was one. 
// In C# the preprocessor directives are used to help in conditional compilation. Unlike C and C++ directives, they are not used to create macros. 
// A preprocessor directive must be the only instruction on a line.


namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {

#if (PI)
            Console.WriteLine("PI is defined");

#else
            Console.WriteLine("PI is not defined");
#endif

#if (DEBUG && !VC_V10)
         Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
         Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
            Console.WriteLine("DEBUG and VC_V10 are defined");
#else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
#endif

        }
    }
}
