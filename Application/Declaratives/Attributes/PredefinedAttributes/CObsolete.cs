using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.Attributes.PredefinedAttributes
{
    class CObsolete
    {
        /*
         * This predefined attribute marks a program entity that should not be used. 
         * It enables you to inform the compiler to discard a particular target element. 
         * For example, 
                when a new method is being used in a class and if you still want to retain the old method in the class, 
                you may mark it as obsolete by displaying a message the new method should be used, instead of the old method.

            Syntax for specifying this attribute is as follows −

            [Obsolete (
               message
            )]

            [Obsolete (
               message,
               iserror
            )]
            Where,

            The parameter message, is a string describing the reason why the item is obsolete and what to use instead.

            The parameter iserror, is a Boolean value. If its value is true, the compiler should treat the use of the item as an error. 
                    Default value is false (compiler generates a warning).
         */
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]  // true OR false to toggle it
        void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }

        public static void Example()
        {
            CObsolete obj = new CObsolete();
            // obj.OldMethod();    // On Compilation, It gives an error message stating − Don't use OldMethod, use NewMethod instead
            obj.NewMethod();    // No Error
        }
    }
}
