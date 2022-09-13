using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
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

        public static void Run()
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //calling the FindMax method
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}

namespace RecursiveCalculatorApplication
{
    class NumberManipulator
    {
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
        public static void Run()
        {
            NumberManipulator n = new NumberManipulator();
            //calling the factorial method {0}", n.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
            Console.ReadLine();
        }
    }
}

namespace PassingParametersByValue
{
    class NumberManipulator
    {
        public void swap(int x, int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        public static void Run()
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(a, b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}

namespace PassingParametersByReference
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        public static void Run()
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}

namespace PassingParametersByOutput
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static void Run()
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int a = 100, b;

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value */
            n.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);

            /* calling a function to get the values */
            n.getValues(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}

namespace Methods
{

    class Program
    {

        static void Main(string[] args)
        {
            /*
                < Access Specifier > < Return Type > < Method Name > (Parameter List) {
                    Method Body
                }
            */
            CalculatorApplication.NumberManipulator.Run();
            RecursiveCalculatorApplication.NumberManipulator.Run();
            PassingParametersByValue.NumberManipulator.Run();
            PassingParametersByReference.NumberManipulator.Run();

            // A return statement can be used for returning only one value from a function. 
            // However, using output parameters, you can return two values from a function. 
            // Output parameters are similar to reference parameters, except that they transfer data out of the method rather than into it.

            PassingParametersByOutput.NumberManipulator.Run();

            Console.ReadLine();
        }
    }
}
