namespace ControlStatements
{
  internal class Continue
  {
    /*
     * Syntax:
     *        continue;
     */
    public static void Example()
    {
      // The continue statement in C# forces the next iteration of the loop to take place, skipping any code in between.
      {
        /* local variable definition */
        int a = 10;
        do /* do loop execution */
        {
          if (a == 15)
          {            
            a = a + 1;
            continue; /* skip the iteration */
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
            continue; // Jump to the next iteration
          }
          Console.WriteLine("Odd number: " + i);
        }
        Console.WriteLine("Loop completed.");
      }
    }
  }
}
