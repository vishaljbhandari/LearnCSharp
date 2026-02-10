using System.Text;

namespace Strings
{
  internal class Strings
  {
    public static void Example()
    {
      /*
        Strings are used for storing text containing one or more words.  
        The string keyword is an alias for the System.String class
       */
      {
        string greeting;
        greeting = "Hello";
        greeting = "Nice to meet you!";
        Console.WriteLine("Hello, World!");
      }
      {
        // creating a string in C# using string literals or the String class.
        string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine("The length of the txt string is: " + txt.Length);  // length of a string using the Length property
      }
      {
        string txt = "Hello World";
        Console.WriteLine(txt);
        Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
        Console.WriteLine(txt.ToLower());   // Outputs "hello world"
      }
      {
        string str = "C# by TP";
        foreach (char ch in str)
        {
          Console.WriteLine(ch);
        }
      }
      {
        // Compare two strings using the String.Compare method or the equality operator.
        string str1 = "Hello";
        string str2 = "World";

        if (String.Compare(str1, str2) == 0)
        {
          Console.WriteLine("Strings are equal.");
        }
        else
        {
          Console.WriteLine("Strings are not equal.");
        }
      }
      {
        // check if a string contains another string using the Contains method.
        string str = "Welcome to C# programming";
        if (str.Contains("C#"))
        {
          Console.WriteLine("The sequence 'C#' was found.");
        }
      }
      {
        // extract a part of a string using the Substring method.
        string str = "C# Programming Language";
        Console.WriteLine(str);
        string substr = str.Substring(3, 11);
        Console.WriteLine(substr);
      }
      {
        // join multiple strings using the String.Join method.
        string[] lines = new string[] {
            "C# is a modern",
            "Object-oriented",
            "Programming language"
         };
        string result = String.Join("\n", lines);
        Console.WriteLine(result);
      }
      {
        // StringBuilder helps to modify strings because regular strings cannot be changed directly
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World!");
        sb.Insert(6, "C# ");
        sb.Replace("World", "Everyone");

        Console.WriteLine(sb.ToString());
      }
    }
  }
}