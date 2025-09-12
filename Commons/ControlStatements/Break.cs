namespace ControlStatements
{
  internal class Break
  {
    /*
      When the break statement is encountered inside a loop, the loop is immediately terminated and program control resumes at the next statement following the loop.
      It can be used to terminate a case in the switch statement.

      If you are using nested loops (i.e., one loop inside another loop), the break statement will stop the execution of the innermost loop and start executing the next line of code after the block.
    */
    public static void Example()
    {
      // The break statement in C# forces the current iteration of the loop to break.
      {
        /* local variable definition */
        int a = 10;
        do /* do loop execution */
        {
          if (a == 15)
          {
            a = a + 1;
            break; /* breaks the iteration */
          }
          Console.WriteLine("value of a: {0}", a);
          a++;
        }
        while (a < 20);
      }
      {
        for (int i = 1; i <= 10; i++)
        {
          if (i % 2 == 0) // Skip even numbers
          {
            break; // break to the current iteration
          }
          Console.WriteLine("Odd number: " + i);
        }
        Console.WriteLine("Loop completed.");
      }
    }
  }
}
