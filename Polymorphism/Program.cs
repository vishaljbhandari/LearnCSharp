using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolymorphismApplication
{
    class Printdata
    {
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        public static void Run()
        {
            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C++");
        }
    }
}

namespace DynamicPolymorphismApplication
{
    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
    class RectangleTester
    {
        public static void Run()
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}

namespace DynamicPolymorphismApplicationVirtual
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
    class Tester
    {
        public static void Run()
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);

        }
    }
}

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticPolymorphismApplication.Printdata.Run();
            DynamicPolymorphismApplication.RectangleTester.Run();
            DynamicPolymorphismApplicationVirtual.Tester.Run();
            Console.ReadKey();
        }
    }
}
