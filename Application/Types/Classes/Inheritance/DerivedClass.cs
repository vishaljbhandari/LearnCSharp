using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.Inheritance
{
    namespace DerivedExample
    {
        /* an existing class from which the other classes are determined and properties are inherited */
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
            public int getArea()
            {
                return (width * height);
            }
        }
    }
    class DerivedClass
    {
        public static void Example()
        {
            /* creating object of base class */
            DerivedExample.Shape shape = new DerivedExample.Shape();
            shape.setWidth(5);
            shape.setHeight(7);
            shape.display();

            DerivedExample.Rectangle rectangle = new DerivedExample.Rectangle();
            rectangle.setWidth(20);
            rectangle.setHeight(30);
            rectangle.display();
            Console.WriteLine("Total area: {0}", rectangle.getArea());
        }
    }
}
