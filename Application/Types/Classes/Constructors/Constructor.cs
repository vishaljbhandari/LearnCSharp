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
            /* class contructor */
            /* A constructor has exactly the same name as that of class
             * it does not have any return type. */

            Console.WriteLine("Object is being created");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class Constructor
    {
        /* A class constructor is a special member function of a class that is executed whenever we create new objects of that class */

            public static void Example()
        {

        }
    }
}
