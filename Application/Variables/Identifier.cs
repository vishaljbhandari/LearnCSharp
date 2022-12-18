using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Variables
{
    class Identifier
    {
        void Basic()
        {
            /*
             * Identifier
             * It is used for identification purposes
             * It is a user-defined name of the program components
             * An identifier can be a class name, method name, variable name, or label. 
             * It can not start with a number.
             *      1route is not a valid identifier
             * 
            */
        }
        void ValidIdentifierRules()
        {
            /*
                Rules for defining identifiers (If not followed, then compiler give an error)
                The only allowed characters for identifiers are all alphanumeric characters
                    ([A-Z], [a-z], [0-9]), ‘_‘ (underscore). 
                    For example “geek@” is not a valid C# identifier
                Identifiers should not start with digits([0-9]). 
                    For example “123geeks” is not valid in the C# identifier.
                Identifiers should not contain white spaces. 
                Identifiers are not allowed to use as keywords unless they include @ as a prefix. 
                    For example, @as is a valid identifier, but “as” is not because it is a keyword.
                C# identifiers allow Unicode Characters.
                C# identifiers are case-sensitive.
                C# identifiers cannot contain more than 512 characters.
                Identifiers do not contain two consecutive underscores in their name 
                    because such types of identifiers are used for the implementation.
             */
        }

        void ValidIdentifiers()
        {
#pragma warning disable 219 // supressing warning CS0219, The variable xx is assigned but its value is never used
            int oneRoute = 5;
            int @as = 5;
            int minutes = 60;
            int math_marks = 45;
#pragma warning restore 219 // restoring warning CS0219, The variable xx is assigned but its value is never used
        }

        void InValidIdentifiers()
        {
            /*
             * int 1route;  starts with number
             * int geek@;   contains special character
             * int as;      it is a keyword
             */
        }

        static void Example()
        {
            Identifier identifier = new Identifier();
            identifier.Basic();
            identifier.ValidIdentifierRules();
            identifier.ValidIdentifiers();
            identifier.InValidIdentifiers();
        }
    }
}
