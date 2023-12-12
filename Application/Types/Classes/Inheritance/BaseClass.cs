using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.Inheritance
{
    namespace BaseExample
    {
        /* an existing class from which the other classes are determined and properties are inherited */
        class Shape
        {
            protected int width;
            protected int height;
            public Shape(int h, int w)
            {
                height = h;
                width = w;
            }
            public Shape()
            {
                height = 0;
                width = 0;
            }
            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
            public void display()
            {
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Height: {0}", height);
            }
        }
        /* a class becomes base class only when it is inherited by another class */
        class Rectangle : Shape
        {
            /* here class Rectangle is inheriting Shape, then Shape class becomes base class of Rectangle class */
            public Rectangle() : base(0, 0)
            {
                /* base class object should be created before the subclass is created by calling base class constructor using base() */
            }
            public Rectangle(int l, int w) : base(l, w)
            {
                /* base class object should be created before the subclass is created by calling base class constructor using base() */
            }
            public int getArea()
            {
                return (width * height);
            }
        }
    }
    class BaseClass
    {
        public static void Example()
        {
            /* creating object of base class */
            BaseExample.Shape shape = new BaseExample.Shape();
            shape.setWidth(5);
            shape.setHeight(7);
            shape.display();

            BaseExample.Rectangle rectangle = new BaseExample.Rectangle();
            rectangle.setWidth(20);
            rectangle.setHeight(30);
            rectangle.display();
            Console.WriteLine("Total area: {0}", rectangle.getArea());
        }
    }
}
