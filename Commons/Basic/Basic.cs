using System; // using system name
// single line comment

/* multi
   line
   comment */

// C# ignores white space. However, multiple lines makes the code more readable.
namespace Basic // namespace is used to organize your code, and it is a container for classes and other namespaces.
{
  class Basic   // class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class
  {
    static void Main(string[] args) // Main function, the entry point of a C# application 
    {
      Console.WriteLine("Hello World!");
      System.Console.WriteLine("Fully Qualified Name For WriteLine");
    }
  }
}