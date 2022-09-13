using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    // The idea of inheritance implements the IS-A relationship
    // It provides an opportunity to reuse the code functionality and speeds up implementation time
    // new class should inherit the members of an existing class. This existing class is called the base class, and the new class is referred to as the derived class.
    /*
        <acess-specifier> class <base_class>
        {
           ...
        }

        <acess-specifier> class <derived_class> : <base_class> 
        {
           ...
        }
    */

    class Shape
    {
        protected int width;
        protected int height;
        int area;
        public Shape(int h, int w)
        {
            Console.WriteLine("Shape Width {0}", w);
            Console.WriteLine("Shape Height {0}", h);
            height = h;
            width = w;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    // Derived class
    class Rectangle : Shape
    {
        int area;
        public Rectangle(int h, int w) : base(h, w) // to call base class parameterized constructor //
        {
            Console.WriteLine("Rectangle Width {0}", getWidth());
            Console.WriteLine("Rectangle Height {0}", getHeight());
        }
        public int getArea()
        {
            return getHeight() * getWidth();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                Rectangle Rect = new Rectangle(5, 7);

                // Print the area of the object.
                Console.WriteLine("Total area: {0}", Rect.getArea());

                MultipleInheritance.RectangleTester.Run();

        
                Console.ReadKey();
        }
    }
}

namespace MultipleInheritance
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Base class PaintCost
    public interface PaintCost
    {
        int getCost(int area);
    }

    // Derived class
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }
    class RectangleTester
    {
        public static void Run()
        {
            Rectangle Rect = new Rectangle();
            int area;

            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));

        }
    }
}