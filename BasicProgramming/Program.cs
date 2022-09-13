using System;       // Using System Namespace
using System.Collections.Generic;   // Using descriptive name of a class or resource
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{   // Code block starts using {
    class Program
    {
        // Class variable/property members to hold data
        public static string title = "Programming";     // Static string variable with public scope (Initialized)
        public static int version;                      // Static int variable with public scope (Uninitialized)
        public static int number = 5;                   // Static int variable with public scope (Initialized)

        // Class function members to define behaviours
        static void Main(string[] args) // Static function
        {
            version = 1;    // Static members can use other static members
            // Local variable using "var" keyword
            // C# supports implicit typing, this can be achieved by var keyword
            // C# compiler will automatically figureout type of value, being assigned and then it set type of variable accordingly
            var message = string.Format("Welcome to {0} version {1}.{2}!", title, version, number);
            // Using var keyword declaration, assignment is must else it will give error
            // Native string class with Format function
            // Format function is used to form string using multiple placeholders
            Console.WriteLine(message);
            Console.ReadLine();


            // Dealring Variable 
            // typename variableName [ = value ];

            // C# varibale name usage lowerCamelCase

        }
    }
}   // Code block ends using }
