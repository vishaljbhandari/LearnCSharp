using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.Constructors
{
    class DoubleLine
    {
        private double length;   // Length of a line

        public DoubleLine()
        {
            /* default constructor without any parameter */
            Console.WriteLine("Object is being created, Length: " + length);
        }
        public DoubleLine(double len)
        {
            length = len;
        }
    }
    class ConstructorDefault
    {
        /* A default constructor does not have any parameter */
        public static void Example()
        {

        }
    }
}
