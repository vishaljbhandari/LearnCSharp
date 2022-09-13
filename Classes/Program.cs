using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Classes
{

    class Box
    {
        public double length;   // Length of a box
        public double breadth;  // Breadth of a box
        public double height;   // Height of a box

        // Class constructor
        // Special member function of a class
        // Executed whenever we create new objects of that class.
        // Same name as that of class
        // No return type, Does not return anything
        // Constructors can be overloaded and overriden
        public Box() {  // Default, user defined constructor, No parameters
            Console.WriteLine("Object is being created");
        }

        // Parameterized constructors with parameters can be created, if required
        public Box(int value)
        {  // Default, user defined constructor, No parameters
            Console.WriteLine("Object is being created - using parameterized constructor {0}", value);
        }

        // Class Destructors, a special member function of a class
        // Eexecuted whenever an object of its class goes out of scope.
        // Same name as that of the class with a prefixed tilde(~)
        // No return type, Does not return anything
        // It does not take any parameter, No parameterized destructor
        // Used to release memory resources before exiting the program
        // Destructors cannot be inherited or overloaded.
        ~Box()
        {   //destructor
            Console.WriteLine("Object is being deleted");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }

        // Static Class Members
        // Declare class members as static using the static keyword
        // Does not need object to access static members
        // Only one copy of the static member, only one instance of the member exists for a class
        // Usually used for defining constants because their values can be retrieved by invoking the class without creating an instance of it
        // Static variables can be initialized inside or outside the member function or class definition
        public static int num;  // declaring inside but not initialized inside
        public static int number = 5;  // Declaraing and initializing inside the class

        // A member function as static. It can access only static variables. 
        // The static functions exist even before the object is created. 
        public static int getNum()
        {
            return num;     // Static members can use only static members.
        }
    }

    // <access specifier> class class_name
    // Default access specifier for a class type is internal. 
    class Program
    {
        // Default access for the members is private
        /* member variables
            <access specifier> <data type> variable1;
            <access specifier> <data type> variable2;
            ...
            <access specifier> <data type> variableN;
        */

        /*
        // member methods
        <access specifier> <return type> method1(parameter_list)
            {
                // method body
            }
        <access specifier> <return type> method2(parameter_list)
            {
                // method body
            }
        ...
        <access specifier> <return type> methodN(parameter_list)
        {
            // method body
        }
        */

        static void Main(string[] args)
        {
            Box Box1 = new Box();   // Declare Box1 object of type Box
            Box Box2 = new Box();   // Declare Box2 object of type Box 
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.height = 5.0;  // accessing public members using . operator with object name
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // box 2 specification
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            // volume of box 1
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Volume of Box2 : {0}", volume);

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

            Console.ReadKey();
        }
    }   // no need of terminating semicolom for class
} // no need of terminating semicolom for namespace
