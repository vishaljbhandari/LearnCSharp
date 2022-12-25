using System;
/*
 * using keyword is used to import a class or namespace into our current code
 * It is also opening the content of given namespace for use
 * Prefer using specific import by using more deeper URL
 * Importing outermost namespace will open too much code into our application
 * using System.Collections.Generic;    -> importing only System.Collections.Generic
 * using System;    ->  importing everything under System namespace
 */

namespace Application  // Global/outer most namespace, same as project name
{
    /* Every visual studio application has a class "Program"
     * In C# everything is a class
     * Each block starts with "{" and ends with "}" curly braces
     */
    class Program   
    {
        /*
         * Each class can have function
         * Each C# project has landing main function. Which is called/invoked by Operating System
         * This landing main function should be static, so that it can be called using class name without creating object
         * This should be a public method so that it is visible outside and can be called from outside
         * In C# program does not need to return any thing back. Hence this function should have void return type
         * This function also accepts arguments from console to recieve input data. This is called command line arguments.
         * Main function name must be a Capitalized word, not MAIN or main. Only Main is allowed.
         * Main() is an entry point of application
         */
        static void Main(string[] args) /* args is an array holding Command Line Arguments, its optional */
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}
