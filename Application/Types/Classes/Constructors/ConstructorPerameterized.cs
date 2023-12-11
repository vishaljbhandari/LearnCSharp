using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.Constructors
{
    class Circle
    {
        private double radius;   // Length of a line

        public Circle(double len)
        {
            /* Parameterized constructor, that can have parameters */
            /* it helps you to assign initial value to an object at the time of its creation */
            Console.WriteLine("Object is being created, radius = {0}", len);
            radius = len;
        }
    }
    class ConstructorPerameterized
    {
        public static void Example()
        {

        }
    }
}
