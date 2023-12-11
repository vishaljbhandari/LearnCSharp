﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.StaticMembers
{
    class StaticFunctionExample
    {
        public static int num;

        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    class StaticFunctions
    {
        /*  You can also declare a member function as static.
         *  Such functions can access only static variables
         *  The static functions exist even before the object is created
        */
        public static void Example()
        {
            StaticFunctionExample obj = new StaticFunctionExample();

            obj.count();
            obj.count();
            obj.count();

            Console.WriteLine("Variable num: {0}", StaticFunctionExample.getNum());
        }
    }
}
