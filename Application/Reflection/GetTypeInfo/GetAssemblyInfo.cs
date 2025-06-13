using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reflection.GetTypeInfo
{
    /*
     * You can also retrieve information about assemblies using the reflection.
     */

    class GetAssemblyInfo
    {
        public static void Example()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assembly Full Name: " + assembly.FullName);

            Console.WriteLine("Defined Types:");
            foreach (var t in assembly.DefinedTypes)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
