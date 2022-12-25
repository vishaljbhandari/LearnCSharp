using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings as array of characters (Trivial Way)
            // Use the string keyword to declare a string variable. The string keyword is an alias for the System.String class.
            // from string literal and string concatenation
            string fname, lname;        // decalration using String class
            fname = "Rowan";               // Assignment
            lname = "Atkinson";
            Console.WriteLine("fname {0},  lname {1}", fname, lname);

            System.String name = "My Name"; // Declaration, Initialization
            Console.WriteLine("name: {0}", name);

            Console.WriteLine("Length: {0}", name.Length);  // Length property of string class

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };   // As character ARRAY
            Console.WriteLine("letters: {0}", letters);    // Printing character array

            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            Console.WriteLine("sarray: {0}", sarray);    // Printing character array

            string fullname = fname + lname;        // concatenation using "+" operator
            Console.WriteLine("Full Name: {0}", fullname);

            char[] m1 = { 'H', 'e', 'l', 'l', 'o', '1'};
            char[] m2 = { 'H', 'e', 'l', 'l', 'o', '2'};
            // string concateArray = m1 + m2; // concatenation does not work on char arrays, it works only on string objects
            string concateArray = m1.ToString() + m2.ToString();    // works as char arrays are converted into string objects before

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters); // converting char array into string // pass into string constructor
            Console.WriteLine("Greetings: {0}", greetings);
            string msg = letters.ToString();    // converting char array into string using function
            Console.WriteLine("message: {0}", msg);

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);  // join function of Array class using seperator and 2d dimension character array
            Console.WriteLine("Message: {0}", message);

            Console.WriteLine("Message: {0}", String.Join("-", sarray));    // join using join function


            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            string str1 = "This is test";
            string str2 = "This is text";
            if (String.Compare(str1, str2) == 0)    // comparing strings // 0 if equal // -1 if not equal
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }

            string str = "This is test";

            if (str.Contains("test"))   // checks if sub string is present in string object or not // returns true or false
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            string str3 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str3);
            string substr = str3.Substring(23); // return string from 23rd position upto end
            Console.WriteLine(substr);

            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string newString = String.Join("\n", starray);    // join strings using connector string
            Console.WriteLine(newString);


            Console.ReadLine();
        }
    }
}
