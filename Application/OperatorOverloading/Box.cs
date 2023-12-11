using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.OperatorOverloading
{
    class Box
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box
        public double getVolume()
        {
            return length * breadth * height;
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
        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
}
