using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CString
{
    /* Creating a String Object */
    class StringCreate
    {
        void usingStringLiteral()
        {
            /* By assigning a string literal to a String variable */
            string stringName = "Rowan";
            char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
            string[] stringArray = { "Hello", "From", "Tutorials", "Point" };
            Console.WriteLine("stringName: {0}", stringName);
            Console.WriteLine("charArray: {0}", charArray);
            Console.WriteLine("stringArray: {0}", stringArray);
        }

        void usingStringClassConstructor()
        {
            /* By using a String class constructor */
            char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(charArray);
            Console.WriteLine("Greetings: {0}", greetings);
        }
        void usingStringConcatenationOperator()
        {
            /* By using the string concatenation operator (+) */
            string fname = "Raj";
            string lname = "Kumar";
            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);
        }

        void usingStringReturningFunction()
        {
            /* By retrieving a property or calling a method that returns a string */
            string[] stringArray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", stringArray);
            Console.WriteLine("Message: {0}", message);
        }
        void usingStringFormattingMethod()
        {
            /* By calling a formatting method to convert a value or an object to its string representation */
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }

        public static void Example()
        {
            StringCreate obj = new StringCreate();
            obj.usingStringLiteral();
            obj.usingStringClassConstructor();
            obj.usingStringConcatenationOperator();
            obj.usingStringReturningFunction();
            obj.usingStringFormattingMethod();
        }
    }
}