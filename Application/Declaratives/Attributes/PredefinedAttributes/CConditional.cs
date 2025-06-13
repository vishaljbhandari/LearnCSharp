using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   // required for ConditionalAttributes

namespace Application.Declaratives.Attributes.PredefinedAttributes
{
    public class Myclass
    {
        [Conditional("DEBUG")]

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class CConditional
    {
        void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }
        void function2()
        {
            Myclass.Message("In Function 2.");
        }
        public static void Example()
        {
            CConditional obj = new CConditional();

            obj.function1();

        }
    }
}
