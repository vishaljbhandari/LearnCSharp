using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.Constructors
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            /* default constructor without any parameter */
            Console.WriteLine("Object is being created");
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
