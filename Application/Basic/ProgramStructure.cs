using System;
/*
    A C# program consists of the following parts −

     Namespace declaration
     A class
     Class methods
     Class attributes
     A Main method
     Statements and Expressions
     Comments
*/          // Comments

namespace Application.Basic         // Namespace declaration
{
    class ProgramStructure             // A class
    {
        static string className = "ProgramStructure";     // Class attributes
        static void Example()       // Class methods 
        {
            Console.WriteLine("Hello World " + className);   // Statements and Expressions
            Console.ReadKey();
        }
        /*
            static void main()          // A Main method
            {

            }
        */
    }
}
