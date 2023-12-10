using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CArray
{
    class ArrayBasic
    {
        /*
         * An array
         * stores a fixed-size sequential collection of elements of the same type
         * a collection of variables of the same type stored at contiguous memory locations
         * used to store a collection of data 
         * Array is a reference type
         * 
         * Instead of decalring multiple variables, decalre one array variable of that count
         * any specific element can be accessed using index
         * 
         * All arrays consist of contiguous memory locations. 
         *      lowest address corresponds to the first element 
         *      highest address to the last element.
         */
        void declaringArray()
        {
            /*
             * Declaring Array:
             * 
             * datatype[] arrayName;
             * 
             * datatype is used to specify the type of elements in the array
             * [ ] specifies the rank of the array. The rank specifies the size of the array
             * arrayName specifies the name of the array.
             * 
             * Declaring an array does not initialize the array in the memory
             * Without initialization we can not assign values to array
             */

            double[] balance;   // array of double type;
        }

        void initializingArray()
        {
            /*
             * When the array variable is initialized, you can assign values to the array
             * use the new keyword to create an instance of the array
             * 
             * Initializing Array:
             * 
             * 
             */

            double[] balance = new double[10];       // with declaration
            double[] sums;
            sums = new double[10];                  // without declaration
        }

        void assigningValues()
        {
            /*
             * You can assign values to individual array elements, by using the index number
             */
            {
                /*
                 * array_variable[index] = value;
                 * value should be of array element type
                 */
                double[] balance = new double[10];
                balance[0] = 4500.0;
            }

            {
                /* Array assignment can be done at the time of decalraion as well */
                double[] sums = { 2340.0, 4523.69, 3421.0 };        // size is omitted, auto deduce from count of values provided
            }

            {
                /* creating and initializing an array */
                int[] marks = new int[5] { 99, 98, 92, 97, 95 };

                int[] amounts = new int[] { 99, 98, 92, 97, 95 };   // size is omitted, auto deduce from count of values provided
            }
            
            {
                /* copying an array variable into another target array variable. Both array points to the same memory location */
                int[] marks = new int[] { 99, 98, 92, 97, 95 };
                int[] score = marks;
            }

            /* When you create an array, C# compiler implicitly initializes each array element to a default value depending on the array type */
        }

        void accessingValues()
        {
            /*
             * An array element can be accessed by index with the array name
             * This is done by placing the index of the element within square brackets after the name of the array
             * type value = array_variable[index];
             * value should be of array element type
             */
            double[] balance = new double[10];
            balance[0] = 4500.0;
        }

        public static void Example()
        {
            ArrayBasic obj = new ArrayBasic();
            obj.declaringArray();
            obj.initializingArray();

        }
    }
}
