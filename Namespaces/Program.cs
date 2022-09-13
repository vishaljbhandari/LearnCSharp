using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using third;        // opening up third namespace, now its all collection names can be used freely with in this scope

using fifth.sixth;  // Opening up fifth.sixth namespace, now its all collection names can be used freely with in this scope


namespace first
{
    class cl
    {
        public void func1()
        {
            Console.WriteLine("Inside first");
        }
    }
}

namespace second
{
    class c2
    {
        public void func2()
        {
            Console.WriteLine("Inside second");
        }
    }
}

namespace third
{
    class c3
    {
        public void func3()
        {
            Console.WriteLine("Inside third");
        }
    }
}

namespace forth
{
    class c4
    {
        public void func4()
        {
            Console.WriteLine("Inside forth");
        }
    }
}

namespace fifth
{
    class c5
    {
        public void func5()
        {
            Console.WriteLine("Inside fifth");
        }
    }
    namespace sixth
    {
        class c6
        {
            public void func6()
            {
                Console.WriteLine("Inside nexted sixth");
            }
        }
    }
}

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            first.cl fc1 = new first.cl();      // accessing c1 class frin first namespace
            second.c2 sc2 = new second.c2();
            fc1.func1();
            sc2.func2();

            c3 c_third = new c3();        // class opened by third namespace
            c_third.func3();

            c6 c_sixth = new c6();        // class opened by fifth.sixth namespace
            c_sixth.func6();

            Console.ReadKey();
        }
    }
}
