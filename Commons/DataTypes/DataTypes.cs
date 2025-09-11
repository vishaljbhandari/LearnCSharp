using System;
using System.Drawing;
using static System.Formats.Asn1.AsnWriter;

namespace DataTypes
{
  /*
    Data Types
    A data type defines the type of data a variable can hold.
    C# is a strongly typed language, which means that every variable must be declared with a specific data type.
    This helps to ensure that the data is used correctly and prevents errors.
    There are two main categories of data types in C#:
    1. Value Types: These types hold the actual data value. Examples include int, float, double, char, and bool.
    2. Reference Types: These types hold a reference (or address) to the actual data. Examples include string, arrays, classes, and interfaces.
    C# also provides some special data types like object (the base type for all data types) and dynamic (which allows for dynamic typing).
    Here are some commonly used data types in C#:
    - int: Represents a 32-bit signed integer.
    - float: Represents a single-precision floating-point number.
    - double: Represents a double-precision floating-point number.
    - char: Represents a single character (enclosed in single quotes).
    - bool: Represents a boolean value (true or false).
    - string: Represents a sequence of characters (enclosed in double quotes).
    - decimal: Represents a high-precision decimal number, often used for financial calculations.

  */

  internal class DataTypes
  {
    public static void Example()
    {
      {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String
        decimal myDecimal = 19.99M;  // Decimal number
        Console.WriteLine(myNum);
        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);
        Console.WriteLine(myDecimal);
      }
      {
        /*
          Number types are divided into two groups:
          Integer types stores whole numbers, positive or negative (such as 123 or -456), without decimals. Valid types are int and long. Which type you should use, depends on the numeric value.
          Floating point types represents numbers with a fractional part, containing one or more decimals. Valid types are float and double.
        */
      }
      {
        // Integer Types
        // Int: The int data type can store whole numbers from -2147483648 to 2147483647.In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.
        int myInt = 100000;
        Console.WriteLine(myInt);
        // Long: The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807.This is used when int is not large enough to store the value. Note that you should end the value with an "L":
        long myLong = 15000000000L;
        Console.WriteLine(myLong);
      }
      {
        // Floating Point Types
        // The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles:
        float myFloat = 5.75F;
        Console.WriteLine(myFloat);
        double myDouble = 19.99D;
        Console.WriteLine(myDouble);
      }
      {
        // Scientific Numbers: A floating point number can also be a scientific number with an "e" to indicate the power of 10:
        double myScientificNum = 1.5E4; // 1.5 * 10^4 = 15000
        Console.WriteLine(myScientificNum);
        double d1 = 12E4D;
        Console.WriteLine(d1);
      }
    }
  }
}