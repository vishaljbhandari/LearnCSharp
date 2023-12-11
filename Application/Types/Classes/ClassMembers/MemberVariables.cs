using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.ClassMembers
{
    class Box
    {
        /* private member variables */
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        /* public methods to access private member variables outside the class */
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
    }
    class MemberVariables
    {
        /*
         * Member variables are the attributes of an object (from design perspective)
         * Usually member variables are kept private to implement encapsulation and can only be accessed using the public member functions.
         */
        int value;
        void initializingMemberVariables()
        {
            /* usually done by either contructors or setter functions */
        }
        void accessingMemberVariables()
        {
            /* To access the class members, you use the dot (.) operator */
            /* The dot operator links the name of an object with the name of a member */
            MemberVariables obj = new MemberVariables();
            obj.value = 5;
        }
        public static void Example()
        {
            MemberVariables obj = new MemberVariables();
            obj.definingMemberVariables();
            obj.initializingMemberVariables();
            obj.accessingMemberVariables();
        }
    }
}
