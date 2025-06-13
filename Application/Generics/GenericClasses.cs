using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Generics
{
    /*
     *  A generic class is defined with a type parameter which allows a class to be instantiated with different data types and it maintains the type safety also.
        You write the specifications for the class or the method, with substitute parameters for data types. 
        When the compiler encounters a constructor for the class or a function call for the method, it generates code to handle the specific data type.
     */
    public class MyGenericArray<T>  // Generic class example for type safe reusualbe array
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
    class GenericClasses
    {
        static void Example()
        {

            //declaring an int array
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }

            Console.WriteLine();

            //declaring a character array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();
        }
    }
}
