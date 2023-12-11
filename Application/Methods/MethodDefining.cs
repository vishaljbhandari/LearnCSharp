using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Methods
{
    class MethodDefining
    {
        /*
            <Access Specifier> <Return Type> <Method Name>(Parameter List) {
               Method Body
            }

        * Access Specifier − This determines the visibility of a method from another class.
        * Return type − A method may return a value. 
        *       The return type is the data type of the value the method returns. 
        *       If the method is not returning any values, then the return type is void.
        * Method name − Method name is a unique identifier and it is case sensitive. 
        *       It cannot be same as any other identifier declared in the class.
        * Parameter list − Enclosed between parentheses, the parameters are used to pass and receive data from a method. 
        *       The parameter list refers to the type, order, and number of the parameters of a method. 
        *       Parameters are optional; that is, a method may contain no parameters.
        * Method body − This contains the set of instructions needed to complete the required activity.
        *
        */
        public int FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
        public static void Example()
        {

            /* Calling Methods in C# using the name of the method */
            /* if within class scope then without using object
             * if accessing outside class using object */

            MethodDefining obj = new MethodDefining();
            int maxValue = obj.FindMax(10, 25);
        }
    }
}
