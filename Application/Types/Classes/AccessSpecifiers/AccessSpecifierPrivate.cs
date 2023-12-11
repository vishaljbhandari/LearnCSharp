using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.AccessSpecifiers
{
    class PrivateRectangle
    {
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
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
    class AccessSpecifierPrivate
    {
        /*
         * Private access specifier
         *  allows a class to hide its member variables and member functions from other functions and objects
         *  Only functions of the same class can access its private members
         *  Even an instance of a class cannot access its private members
         *  static member functions can access these private members
         *  
         *  private members can be access using public functions of that class
         */

        private double length;
        private double width;
        public static void Example()
        {
            AccessSpecifierPublic obj = new AccessSpecifierPublic();
            /* static member functions can access these private members*/
            obj.length = 5;
            obj.width = 4;
            Console.WriteLine("Length: {0}", obj.length);
            Console.WriteLine("Width: {0}", obj.width);

            PrivateRectangle rectObj = new PrivateRectangle();
            rectObj.Acceptdetails();
            rectObj.Display();
        }
    }
}
