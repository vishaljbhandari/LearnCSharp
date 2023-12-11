using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Basic.Namespaces
{

    /*
     *   A namespace is a declarative region that provides a scope to the identifiers (the names of types, functions, variables, etc) inside it
     * 
     *   The class/method/variable names declared in one namespace does not conflict with the same class/method/variable names declared in another
     */

    /* A namespace definition begins with the keyword namespace followed by the namespace name */
    namespace first_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside first_space");
            }
        }
    }
    namespace second_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside second_space");
            }
        }
    }

    /* To call the namespace-enabled version of either function or variable, prepend the namespace name */
    /* namespace_name.item_name; */
    class CNamespaces
    {
        public static void Example()
        {
            first_space.namespace_cl fc = new first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();
            fc.func();
            sc.func();

            UsingKeyword.Example();
            NestedNamespaces.Example();
        }
    }
}
