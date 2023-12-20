using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Constants
{
    class StringLiteral
    {
        /*
         * String literals or constants are enclosed in double quotes "" or with @""
         * 
         * A string contains characters that are similar to character literals: plain characters, escape sequences, and universal characters.
         * 
         * You can break a long line into multiple lines using string literals and separating the parts using whitespaces.
         */
        /*
         *  Examples
         
            "hello, dear"
            "hello, \
            dear"
            "hello, " "d" "ear"
            @"hello dear"

         */
        public static void Example()
        {
            const string one = "Amit";
            // displaying first constant string
            Console.WriteLine(one);

            const string two = "Tom";
            const string three = "Steve";

            // compile-time error
            // one = "David";

            Console.WriteLine(two);
            Console.WriteLine(three);
        }
    }
}
