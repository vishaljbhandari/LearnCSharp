using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Delegates.AnonymousMethods
{
    class AMethodToLambdaExpression
    {
        /*
         * To create shorter syntax for inline methods, you can simplify anonymous methods by converting them to lambda expressions.
         */

        public static void Example()
        {
            // an anonymous method can be replaced by a lambda expression using the Action delegate
            // Using an anonymous method
            Action<string> greet1 = delegate (string name) {
                Console.WriteLine("Anonymous Method: Hello, " + name + "!");
            };
            greet1("Prakash");

            // Using a lambda expression
            Action<string> greet2 = (name) => {
                Console.WriteLine("Lambda Expression: Hello, " + name + "!");
            };
            greet2("Sudhir");
        }

    }
}
