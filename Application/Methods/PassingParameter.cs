using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Methods
{
    class PassingParameter
    {
        /*
         * When method with parameters is called, you need to pass the parameters to the method. 
         * There are three ways that parameters can be passed to a method
         */
        void valueParameters(int x, int y)      /* value parameter */
        {
            /*
             * This method copies the actual value of an argument into the formal parameter of the function. 
             * In this case, changes made to the parameter inside the function have no effect on the argument.
             * copies of parameters are created at new memory place
             */
            x = 5;
            y = 7;
        }
        void ReferenceParameters(ref int x, ref int y)      /* reference parameter */
        {
            /*
             * A reference parameter is a reference to a memory location of a variable
             * You can declare the reference parameters using the ref keyword
             * Instead of passing values, reference of arguments are passed
             * called function does not create new memory space
             */
            x = 5;
            y = 7;
        }

        void outputParameters(int x, int y, out int result)      /* value parameter */
        {
            /*
             * A return statement can be used for returning only one value from a function
             * However, using output parameters, you can return two or more values from a function
             * Output parameters are similar to reference parameters, except that they transfer data out of the method rather than into it
             */

            result = x + y;
        }
        public static void Example()
        {
            PassingParameter passingParameter = new PassingParameter();
            {
                int first = 5;
                int second = 7;
                Console.WriteLine("Before Pass by value, values -> first : {0}, second : {1}", first, second);
                passingParameter.valueParameters(first, second);
                Console.WriteLine("After Pass by value, values -> first : {0}, second : {1}", first, second);
            }
            {
                int first = 5;
                int second = 7;
                Console.WriteLine("Before Pass by reference, values -> first : {0}, second : {1}", first, second);
                passingParameter.ReferenceParameters(ref first, ref second);
                Console.WriteLine("After Pass by reference, values -> first : {0}, second : {1}", first, second);
            }
            {
                int first = 5;
                int second = 7;
                int result = 0;
                Console.WriteLine("values -> first : {0}, second : {1}", first, second);
                passingParameter.outputParameters(first, second, out result);
                Console.WriteLine("Sum, returned by output parameter , result -> {0}", result);
            }
        }
    }
}
