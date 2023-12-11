#define DEBUG
#define VC_V10
#define PI
#define FI

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Preprocessor
{
    class Conditional
    {
        /*
         * Conditional directives
         *  #if directive is used to create a conditional directive
         *  useful for testing a symbol or symbols to check if they evaluate to true. 
         *  If they do evaluate to true, the compiler evaluates all the code between the #if and the next directive.
         *  
         *  #if symbol [operator symbol]...
         *  
         *  The operator symbol is the operator used for evaluating the symbol (==, !=, &&, ||)
         */
        void ifelsePreprocessor()
        {
            /*
                #if
                It allows testing a symbol or symbols to see if they evaluate to true.

                #else
                It allows to create a compound conditional directive, along with #if.

                #elif
                It allows creating a compound conditional directive.

                #endif
                Specifies the end of a conditional directive. 
            */
#if (PI)
            Console.WriteLine("PI is defined");
#elif (FI)
            Console.WriteLine("FI is defined");
#else
            Console.WriteLine("PI and FI are not defined");
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

        public static void Example()
        {
            Conditional obj = new Conditional();
            obj.ifelsePreprocessor();
        }
    }
}
