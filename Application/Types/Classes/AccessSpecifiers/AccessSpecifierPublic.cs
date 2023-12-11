using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.AccessSpecifiers
{
    class AccessSpecifierPublic
    {
        /*
         * Public access specifier
         *  allows a class to expose its member variables and member functions to other functions and objects
         *  Any public member can be accessed from outside the class
         */

        public double length;
        public double width;
        public static void Example()
        {
            AccessSpecifierPublic obj = new AccessSpecifierPublic();
            obj.length = 5;
            obj.width = 4;
            Console.WriteLine("Length: {0}", obj.length);
            Console.WriteLine("Width: {0}", obj.width);
        }
    }
}
