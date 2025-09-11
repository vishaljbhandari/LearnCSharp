using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
  internal class Constants
  {
    public static void Example()
    {
      /*
        Constants
        Constants are like variables, but their value cannot be changed.
        A constant is a type of variable whose value cannot be modified after it has been assigned.
        This means that once a constant is declared and initialized with a value, that value remains fixed and cannot be altered throughout the program's execution.
        To create a constant, you must use the const keyword (this is a non-access modifier) before the variable type, and always assign it a value.
        The syntax is: const type constantName = value;
        Note: Constants can be declared only at the class level. You cannot declare a constant inside a method.
        Note: The const keyword is used to declare constants at compile time. If you need to declare a constant whose value is determined at runtime, you can use the readonly keyword instead.
      */
      const int myNum = 15;
      Console.WriteLine(myNum);
      // myNum = 20; // This will generate an error: "The left-hand side of an assignment must be a variable, property or indexer"
    }
  }
}
