using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.Destructors
{
    class Square
    {
        private double length;   // Length of a line

        public Square()
        {   /* constructor */
            Console.WriteLine("Object is being created");
        }
        ~Square()
        {   /* destructor */
            Console.WriteLine("Object is being deleted");
        }
    }
    class Destructor
    {
        /* A destructor
         * a special member function of a class that is 
         * executed whenever an object of its class goes out of scope or delete or destroyed 
         * has exactly the same name as that of the class with a prefixed tilde (~)
         * it does not return a value
         * does not take any parameters
         * 
         * can be very useful for releasing memory resources before exiting the program
         * cannot be inherited or overloaded
         */
        public static void Example()
        {
            Square square = new Square();
        }   // destructor is called here as square object is being deleteds
    }
}
