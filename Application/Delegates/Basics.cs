using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Delegates
{
    /*
     * C# delegates are similar to pointers to functions, 
     * in C or C++. A delegate is a reference type variable that holds the reference to a method. 
     * The reference can be changed at runtime.
     * 
     * Delegates are especially used for implementing events and the call-back methods. 
     * All delegates are implicitly derived from the System.Delegate class.
     * 
     */

    /*
        Declaring Delegates

        Delegate declaration determines the methods that can be referenced by the delegate. 
        A delegate can refer to a method, which has the same signature as that of the delegate.
    
        public delegate int MyDelegate (string s);

        The preceding delegate can be used to reference any method that has a single string parameter and returns an int type variable.

        delegate <return type> <delegate-name> <parameter list>
    */

    delegate int NumberChanger(int n);

    class Basics
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Example()
        {
            /*
                Instantiating Delegates / Creating Delegate Instance
                Once a delegate type is declared, a delegate object must be created with the new keyword and be associated with a particular method. 
                When creating a delegate, the argument passed to the new expression is written similar to a method call, 
                but without the arguments to the method.
             */

            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            /*
                Calling Delegates
                <return type> <variable> = <delegate-name>(<parameter list>);

                if you want to discard return value, then
                <delegate-name>(<parameter list>);
            */
            //calling the methods using the delegate objects
            int value1 = nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            int value2 = nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
        }
    }
}
