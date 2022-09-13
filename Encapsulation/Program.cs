using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessSpecifier
{
    class Rectangle
    {
        //member variables
        public double length;
        public double width;

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
    }//end class Rectangle

    class ExecuteRectangle
    {
        public static void Run()
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}

namespace PrivateAccessSpecifier
{
    class Rectangle
    {
        //member variables
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
    }//end class Rectangle

    class ExecuteRectangle
    {
        public static void Run()
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}

namespace InternalAccessSpecifier
{
    class Rectangle
    {
        // member variables
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
    }//end class Rectangle

    class ExecuteRectangle
    {
        public static void Run()
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}

/* Protected Access Specifier
 * Protected access specifier allows a child class to access the member variables and member functions of its base class. 
 * This way it helps in implementing inheritance. We will discuss this in more details in the inheritance chapter.
 */

/*
 * Protected Internal Access Specifier
 * The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application.
 * This is also used while implementing inheritance.
 */

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Encapsulation is implemented by using access specifiers. 
             * An access specifier defines the scope and visibility of a class member.
             * C# supports the following access specifiers −
                Public
                Private
                Protected
                Internal
                Protected internal
            */
            PublicAccessSpecifier.ExecuteRectangle.Run();
            PrivateAccessSpecifier.ExecuteRectangle.Run();
            InternalAccessSpecifier.ExecuteRectangle.Run();

            Console.ReadLine();
        }
    }
}
