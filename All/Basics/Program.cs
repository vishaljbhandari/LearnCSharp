// Single Line Comment

/*
 *  Multiline Comments
 */ 
 
 /* ... */

// Using statement for using resources
// Resources which are graded out are not used in program.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp   // Namespaces
{
    // C# is a java like true object oriented programming language
    // Everything in C# is a OOPs, therefore there is a class for ProjectName for landing point into main function.
    class Program
    {
        // Entry point for any C# program is "Main" function, with in class name similar to project name
        static void Main(string[] args) // similar to java main function in side main class is public static void function with arguments to recieve command line arguments
        {   // This function is called from commandline when we execute this program by OS

            Console.WriteLine("Welcome to C#"); // Console Class // WriteLine function with single string argument
            // All statments ends with ; Semicolon in C#
            // All class and function names are upper camel case (initial uppercase letter, also known as Pascal case)

            Console.WriteLine("Press 1 to continue .. ");
            Console.ReadLine(); // ReadLine function to reach data from console/input
            // Nothing to return, as void function
        }
    }          
    // No terminating semicolon for class end
}
// No terminating semicolon for namespace end

/* 
 * Save this file
 * Click on "start" to build from IDE
 */

/*
 * Visual Studio Text Hinting Facility
 * Suggestions are prompted on typing text
 * Hit tab to autocomplete suggestion
 * Select from suggestion and hit enter
*/