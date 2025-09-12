namespace ControlStatements
{
  internal class WhileLoops
  {
    /*
      C# while loop is a basic control flow statement that allows repeated execution of a block of code as long as a specified condition evaluates to true. 
      This loop construct is useful when the number of iterations is not predetermined.

      A while loop has three main parts:
      1) Initialization: In a counter-controlled loop, where the number of iterations is known, this step defines the counter variable before the loop starts.
      2) Condition: The loop runs as long as this condition is true.
      3) Update (Increment/Decrement): The counter variable inside the condition should change in each iteration to prevent an infinite loop.
    */
    public static void Example()
    {
      {
        /* local variable definition */
        int a = 10;
        /* while loop execution */
        while (a <= 20)
        {
          Console.WriteLine("value of a: {0}", a);
          a++;
        }
      }
    }
  }
}
