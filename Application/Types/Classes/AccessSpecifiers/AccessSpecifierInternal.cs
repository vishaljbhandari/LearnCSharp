using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.AccessSpecifiers
{
    class InternalRectangle
    {
        /* internal member variables */
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class AccessSpecifierInternal
    {
        /* 
         * Internal Access Specifier
         *  allows a class to expose its member variables and member functions to other functions and objects in the current assembly
         *  any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined
         */

        public static void Example()
        {
            InternalRectangle obj = new InternalRectangle();
            obj.length = 4.5;
            obj.width = 3.5;
            obj.Display();
        }
    }
}
