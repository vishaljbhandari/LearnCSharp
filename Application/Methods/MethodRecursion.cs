using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Methods
{
    class MethodRecursion
    {
        /*
         * A method can call itself. This is known as recursion
         */
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        public static void Example()
        {
            MethodRecursion recursion = new MethodRecursion();
            //calling the factorial method {0}", n.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", recursion.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", recursion.factorial(8));
        }
    }
}
