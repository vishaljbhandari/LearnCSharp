using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Delegates
{
    class BuiltInDelegates
    {
        public static void Example()
        {
            // Action<T> Delegate, returns void
            Action<string> greet = name => Console.WriteLine(name);

            // Func<T, TResult> delegate, returns a value
            Func<int, int, int> subtract = (a, b) => a - b;
            Console.WriteLine($"Difference: {subtract(10, 4)}");

            // Predicate<T>	Delegate, Returns bool
            Predicate<string> isShort = s => s.Length < 5;
            Console.WriteLine($"Is 'Hi' short? {isShort("Hi")}");
        }
    }
}
