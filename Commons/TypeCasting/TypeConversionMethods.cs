namespace TypeCasting
{
  internal class TypeConversionMethods
  {
    public static void Example()
    {
      // There are several methods available in C# to convert between different data types. Here are some of the most commonly used methods:
      
      // Convert.ToInt32(): Converts a specified value to a 32-bit signed integer.
      string strNumber = "123";
      int intNumber = Convert.ToInt32(strNumber);
      Console.WriteLine(intNumber); // Outputs: 123

      // Convert.ToDouble(): Converts a specified value to a double-precision floating-point number.
      string strDouble = "123.45";
      double doubleNumber = Convert.ToDouble(strDouble);
      Console.WriteLine(doubleNumber); // Outputs: 123.45
      
      // Convert.ToString(): Converts a specified value to its string representation.
      int num = 456;
      string strNum = Convert.ToString(num);
      Console.WriteLine(strNum); // Outputs: "456"
      
      // int.Parse(): Converts the string representation of a number to its integer equivalent.
      string strParse = "789";
      int parsedNumber = int.Parse(strParse);
      Console.WriteLine(parsedNumber); // Outputs: 789
      
      // double.Parse(): Converts the string representation of a number to its double equivalent.
      string strParseDouble = "789.01";
      double parsedDouble = double.Parse(strParseDouble);
      Console.WriteLine(parsedDouble); // Outputs: 789.01
      
      // ToString(): Converts a value to its string representation.
      double pi = 3.14159;
      string strPi = pi.ToString();
      Console.WriteLine(strPi); // Outputs: "3.14159"
      // Note: When using Parse methods, ensure that the input string is in a valid format to avoid exceptions.
    }
  }
}
