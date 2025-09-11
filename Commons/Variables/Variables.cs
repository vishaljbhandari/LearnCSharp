namespace Variables
{
  class Variables
  {
    /*
      Variables are containers for storing data values.
        Each variable in C# has a specific type, which determines the size and layout of the variable's memory;
        The range of values that can be stored within that memory; and the set of operations that can be applied to the variable.

      To create a variable, you must specify the type and assign it a value. 
      Declaring (Creating) Variables
      The syntax is: type variableName = value;

      In C#, there are different types of variables, for example:
      int - stores integers (whole numbers), without decimals, such as 123 or -123
      double - stores floating point numbers, with decimals, such as 19.99 or -19.99
      char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
      string - stores text, such as "Hello World". String values are surrounded by double quotes
      bool - stores values with two states: true or false
    */
    public static void Example()
    {
      {
        string name = "John";
        // The WriteLine() method is often used to display variable values to the console window.
        Console.WriteLine(name);
      }
      {
        // You can declare multiple variables of the same type in one line:
        int myNum = 15, anotherNumber = 45;
        Console.WriteLine(myNum);
        Console.WriteLine(anotherNumber);
      }
      {
        // You can also declare a variable without assigning the value, and assign the value later:
        int myNum;
        myNum = 15;
        Console.WriteLine(myNum);
      }
      {
        // Note that if you assign a new value to an existing variable, it will overwrite the previous value:
        int myNum = 15;
        myNum = 20; // myNum is now 20
        Console.WriteLine(myNum);
      }
      {
        int myNum = 5;
        Console.WriteLine(myNum);
        double myDoubleNum = 5.99D;
        Console.WriteLine(myDoubleNum);
        char myLetter = 'D';
        Console.WriteLine(myLetter);
        bool myBool = true;
        Console.WriteLine(myBool);
        string myText = "Hello";
        Console.WriteLine(myText);
      }
      {
        // To combine both text and a variable, use the + character:
        string name = "John";
        Console.WriteLine("Hello " + name);
      }
      {
        string firstName = "John ";
        string lastName = "Doe";
        string fullName = firstName + lastName;
        Console.WriteLine(fullName);
      }
      {
        // To declare more than one variable of the same type, use a comma-separated list:
        string firstName = "John", lastName = "Doe", fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);
      }
      {
        //You can also assign the same value to multiple variables in one line:
        int x, y, z;
        x = y = z = 50;
        Console.WriteLine(x);
      }
    }
  }
}