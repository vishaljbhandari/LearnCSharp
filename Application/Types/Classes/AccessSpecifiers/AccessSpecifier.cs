using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.AccessSpecifiers
{
    class AccessSpecifier
    {
        /*
         * Access specifiers specify the access rules for the members as well as the class itself. 
         * If not mentioned, then the default access specifier for a class type is internal. 
         * Default access for the members is private
         * defines the scope and visibility of a class member
         * 
         * Encapsulation is implemented by using access specifiers
         */

        /*
         * C# supports the following access specifiers
         *  Public
         *  Private
         *  Protected
         *  Protected internal
         */

        public static void Example()
        {
            AccessSpecifierPublic.Example();
            AccessSpecifierProtected.Example();
            AccessSpecifierPrivate.Example();
            AccessSpecifierInternal.Example();
            AccessSpecifierProtectedInternal.Example();
        }
    }
}
