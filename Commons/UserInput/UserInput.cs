namespace UserInput
{
  internal class UserInput
  {
    public static void Example()
    {
      {
        // User input can be read from the console using the Console.ReadLine() method.

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userInput = Console.ReadLine();
        Console.WriteLine("You entered: " + userInput);
        // The Console.ReadLine() method returns a string
      }
      {
        // int age = Console.ReadLine();  // Error, Cannot implicitly convert type 'string' to 'int'
        // Console.WriteLine("Your age is: " + age);
      }
      {
        // User Input and Numbers
        // When you use the Console.ReadLine() method to get user input, the input is always returned as a string.
        // If you want to use the input as a number, you must convert it to a numeric type.
        Console.WriteLine("Enter a number:");
        string userInput = Console.ReadLine();
        int userNumber = Convert.ToInt32(userInput);
        Console.WriteLine("You entered the number: " + userNumber);
        // Note: If the user enters a value that cannot be converted to a number, an error will occur.
      }
    }
  }
}