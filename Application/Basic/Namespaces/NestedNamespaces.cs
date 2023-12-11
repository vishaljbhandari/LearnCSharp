using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Basic.Namespaces
{
    /* You can define one namespace inside another namespace */
    namespace first_space
    {
        class abc
        {
            public void func()
            {
                Console.WriteLine("Inside first_space");
            }
        }
        namespace second_space
        {
            class efg
            {
                public void func()
                {
                    Console.WriteLine("Inside second_space");
                }
            }
        }
    }
    class NestedNamespaces
    {
        public static void Example()
        {
            first_space.abc fc = new first_space.abc();
            first_space.second_space.efg sc = new first_space.second_space.efg();
            fc.func();
            sc.func();
        }
    }
}
