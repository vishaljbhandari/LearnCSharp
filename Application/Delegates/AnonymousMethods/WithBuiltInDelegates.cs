using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Delegates.AnonymousMethods
{
    class WithBuiltInDelegates
    {
        /*
         * You can use anonymous methods to define inline logic for built-in delegates such as Action, Func, and Predicate.
         */
        static void Example()
        {
            // Using an anonymous method with the Action delegate
            // Creating an Action delegate instance using an anonymous method
            Action<string> greet = delegate (string name) {
                Console.WriteLine("Hello, " + name + "!");
            };

            // Calling the delegate
            greet("Sudhir");
        }
    }
}
