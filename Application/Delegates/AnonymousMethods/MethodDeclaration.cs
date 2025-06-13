using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Delegates.AnonymousMethods
{
    delegate void NumberChanger(int n);

    /*
     * Anonymous methods provide a technique to pass a code block as a delegate parameter. 
     * Anonymous methods are the methods without a name, just the body.
     * 
     * An anonymous method is a special type of method which does not have any method name. 
     * The method is defined using the "delegate" keyword and it can be assigned to a delegate type variable.
     * 
     * You need not specify the return type in an anonymous method;
     * it is inferred from the return statement inside the method body.
     * 
     * Anonymous methods are declared with the creation of the delegate instance, with a delegate keyword
     */

    class MethodDeclaration
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static int getNum()
        {
            return num;
        }
        public static void Example()
        {
            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);      // Body of Anonymous Mehtod
            };

            /*
             * The delegate could be called both with anonymous methods as well as by passing the method parameters to the delegate object.
             */

            //calling the delegate using the anonymous method 
            nc(10);
            
            //instantiating the delegate using the named methods 
            nc = new NumberChanger(AddNum);
            
            //calling the delegate using the named methods 
            nc(5);
            
            //instantiating the delegate using another named methods 
            nc = new NumberChanger(MultNum);
            
            //calling the delegate using the named methods 
            nc(2);
        }
    }
}
