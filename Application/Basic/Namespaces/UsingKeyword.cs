/* The using keyword states that the program is using the names in the given namespace */

using System;                           // using "System" namesapce 
using System.Collections.Generic;       // using "System.Collections.Generic" namesapce 
using System.Linq;                      // using "System.Linq" namesapce 
using System.Text;                      // using "System.Text" namesapce 
using System.Threading.Tasks;           // using "System.Threading.Tasks" namesapce 

namespace Application.Basic.Namespaces
{
    class UsingKeyword
    {
        /*
         * The using Keyword 
         * The first statement in any C# program is

            "using System;"

            The using keyword is used for including the namespaces in the program. 
            A program can include multiple using statements.
        */
        public static void Example()
        {
            System.Console.WriteLine("Hello there");
        }
    }
}
