using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Constants
{
    class CharacterLiteral
    {
        /*
         * Constant/literals
         * Fixed values that the program may not alter during its execution
         * The constants are treated just like regular variables except that their values cannot be modified after their definition.
         */
        /*
            Escape sequence	    Meaning
            \\	                \ character
            \'	                ' character
            \"	                " character
            \?	                ? character
            \a	                Alert or bell
            \b	                Backspace
            \f	                Form feed
            \n	                Newline
            \r	                Carriage return
            \t	                Horizontal tab
            \v	                Vertical tab
            \xhh . . .	        Hexadecimal number of one or more digits
         */

        public static void Example()
        {
            Console.WriteLine("Hello\tWorld\n\n");
            // character literal within single quote
            char ch = 'a';

            // Unicode representation
            char c = '\u0061';

            Console.WriteLine(ch);
            Console.WriteLine(c);

            // Escape character literal
            Console.WriteLine("Hello\n\nGeeks\t!");

        }
    }
}
