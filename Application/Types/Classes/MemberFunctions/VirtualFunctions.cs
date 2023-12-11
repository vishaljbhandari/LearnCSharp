using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.MemberFunctions
{
    class VirtualFunctions
    {
        class Shape
        {
            protected int width, height;

            public Shape(int a = 0, int b = 0)
            {
                width = a;
                height = b;
            }
            public virtual int area()
            {
                Console.WriteLine("Parent class area :");
                return 0;
            }
        }
        class Rectangle : Shape
        {
            public Rectangle(int a = 0, int b = 0) : base(a, b)
            {

            }
            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * height);
            }
        }
        class Triangle : Shape
        {
            public Triangle(int a = 0, int b = 0) : base(a, b)
            {
            }
            public override int area()
            {
                Console.WriteLine("Triangle class area :");
                return (width * height / 2);
            }
        }
        class Caller
        {
            public void CallArea(Shape sh)
            {
                int a;
                a = sh.area();
                Console.WriteLine("Area: {0}", a);
            }
        }
        public static void Example()
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);
        }
    }
}
