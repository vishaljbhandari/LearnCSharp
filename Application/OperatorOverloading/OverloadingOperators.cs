using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.OperatorOverloading
{
    class OverloadingOperators
    {
        /*
         * You can redefine or overload most of the built-in operators available in C#
         * a programmer can use operators with user-defined types as well
         * 
         * Overloaded operators are functions with special names the keyword operator followed by the symbol for the operator being defined
         * 
         */

        void overloadingExample()
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box3 = Box1 + Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
        }

        public static void Example()
        {
            OverloadingOperators obj = new OverloadingOperators();
            obj.overloadingExample();
        }
    }
}
