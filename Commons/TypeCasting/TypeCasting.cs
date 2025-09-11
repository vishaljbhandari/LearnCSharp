namespace TypeCasting
{
  internal class TypeCasting
  {
    public static void Example()
    {
      // Type casting is when you assign a value of one data type to another type.

      // Implicit Casting (automatically) - converting a smaller type to a larger type size
      // char -> int -> long -> float -> double
      int myInt = 9;
      double myDouble = myInt; // Automatic casting: int to double
      Console.WriteLine(myInt);      // Outputs 9
      Console.WriteLine(myDouble);   // Outputs 9
      // Note: This is safe because the conversion is from a smaller type to a larger type, and there is no risk of data loss.

      // Explicit Casting (manually) - converting a larger type to a smaller size type
      // double -> float -> long -> int -> char
      double myDouble2 = 9.78D;
      int myInt2 = (int)myDouble2; // Manual casting: double to int
      Console.WriteLine(myDouble2);   // Outputs 9.78
      Console.WriteLine(myInt2);      // Outputs 9
      // Note: This can lead to data loss, as the fractional part is truncated.
    }
  }
}