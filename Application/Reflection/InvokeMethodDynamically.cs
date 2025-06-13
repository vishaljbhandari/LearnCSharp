using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reflection
{
    /*
     * You can even invoke methods at runtime by using the reflection.
     */

    class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
    class InvokeMethodDynamically
    {
        public static void Example()
        {
            Type type = typeof(Greeter);
            object obj = Activator.CreateInstance(type);

            MethodInfo method = type.GetMethod("SayHello");
            method.Invoke(obj, new object[] { "Ravi" });
        }
    }
}
