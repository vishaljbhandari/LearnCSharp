using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Methods
{

    class NumberManipulator
    {
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
    }
    class MethodElements
    {
        /* various elements of a method */

        /*
            When you define a method, you basically declare the elements of its structure    

            <Access Specifier> <Return Type> <Method Name>(Parameter List) {
               Method Body
            }

            Access Specifier
            This determines the visibility of a variable or a method from another class.

            Return type
            A method may return a value. The return type is the data type of the value the method returns. 
            If the method is not returning any values, then the return type is void.

            Method name
            Method name is a unique identifier and it is case sensitive. 
            It cannot be same as any other identifier declared in the class.

            Parameter list
            Enclosed between parentheses, the parameters are used to pass and receive data from a method. 
            The parameter list refers to the type, order, and number of the parameters of a method. 
            Parameters are optional; that is, a method may contain no parameters.

            Method body
            This contains the set of instructions needed to complete the required activity.
        */
        public int FindMin(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 < num2)
                result = num1;
            else
                result = num2;

            return result;
        }
        public static void Example()
        {
            MethodElements obj = new MethodElements();
            /*
             * You can call a method using the name of the method
             */
            int min_value = obj.FindMin(15, 36);
            Console.WriteLine("Min value is : {0}", min_value);

            /*
             * You can also call public method from other classes by using the instance of the class
             */
            NumberManipulator numberManipulator = new NumberManipulator();
            int max_value = numberManipulator.FindMax(15, 36);
            Console.WriteLine("Max value is : {0}", max_value);
        }
    }
}
