using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.Attributes.CustomBuiltAttributes
{
    /*
        The .Net Framework allows creation of custom attributes that can be used to store declarative information and can be retrieved at run-time. 
            This information can be related to any target element depending upon the design criteria and application need.

        Creating and using custom attributes involve four steps −
            Declaring a custom attribute
            Constructing the custom attribute
            Apply the custom attribute on a target program element
            Accessing Attributes Through Reflection

        The Last step involves writing a simple program to read through the metadata to find various notations. 
            Metadata is data about data or information used for describing other data. 
            This program should use reflections for accessing attributes at runtime. 
            This we will discuss in the next chapter.
     */

    [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]

        public double GetArea()
        {
            return length * width;
        }
        [DeBugInfo(56, "Zara Ali", "19/10/2012")]

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class CustomAttribute
    {
        public static void Example()
        {
            Rectangle rectangle = new Rectangle(7.5,7.5);
            rectangle.Display();
        }
    }
}
