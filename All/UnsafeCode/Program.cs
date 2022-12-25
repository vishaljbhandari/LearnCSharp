using System;

/*
Pointers
    A pointer is a variable whose value is the address of another variable i.e., the direct address of the memory location.similar to any variable or constant, you must declare a pointer before you can use it to store any variable address.

    The general form of a pointer declaration is −

    type* var-name;
*/

// Valid pointer declarations −

// int* ip;    /* pointer to an integer */
// double* dp;    /* pointer to a double */
// float* fp;    /* pointer to a float */
// char* ch     /* pointer to a character */

// The following example illustrates use of pointers in C#, using the unsafe modifier −

namespace UnsafeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe // or declare function as  "static unsafe void Main"
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                // You can retrieve the data stored at the located referenced by the pointer variable, using the ToString() method
                Console.WriteLine("Data is: {0} ", p->ToString());
                Console.WriteLine("Address is: {0} ", (int)p);
            }

            PointerAsParameter.Run();
            ArrayElementUsingPointer.Run();

            /*
            Compiling Unsafe Code - specify the /unsafe command-line switch with command - line compiler.

            Eg. compiling prog1.cs containing unsafe code, from command line, give the command − (csc /unsafe prog1.cs)

            For Visual Studio IDE (nable use of unsafe code in the project properties)
                Project properties(Solution Explorer) -> Build tab -> Select the option "Allow unsafe code".
            */
            Console.ReadKey();
        }
    }
}
