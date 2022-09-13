using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // While Loop

                /* local variable definition */
                int a = 10;

                /* while loop execution */
                while (a < 20)
                {
                    Console.WriteLine("value of a: {0}", a);
                    a++;
                }
            }

            {
                // for loop
                /* for loop execution */
                for (int a = 10; a < 20; a = a + 1)
                {
                    Console.WriteLine("value of a: {0}", a);
                }
            }
            {
                // Do While Loop
                /* local variable definition */
                int a = 10;

                /* do loop execution */
                do
                {
                    Console.WriteLine("value of a: {0}", a);
                    a = a + 1;
                }
                while (a < 20);
            }
            {
                // Nested Loop
                /* local variable definition */
                int i, j;

                for (i = 2; i < 100; i++)
                {
                    for (j = 2; j <= (i / j); j++)
                        if ((i % j) == 0) break; // if factor found, not prime
                    if (j > (i / j)) Console.WriteLine("{0} is prime", i);
                }
            }
            {
                // Continue Statement
                /* local variable definition */
                int a = 10;

                /* do loop execution */
                do
                {
                    if (a == 15)
                    {
                        /* skip the iteration */
                        a = a + 1;
                        continue;
                    }
                    Console.WriteLine("value of a: {0}", a);
                    a++;
                }
                while (a < 20);

            }
            {
                // break statement
                /* local variable definition */
                int a = 10;

                /* while loop execution */
                while (a < 20)
                {
                    Console.WriteLine("value of a: {0}", a);
                    a++;

                    if (a > 15)
                    {
                        /* terminate the loop using break statement */
                        break;
                    }
                }
            }
            {
                // Infinite Loop
                /*
                for (; ; )
                {
                    Console.WriteLine("Hey! I am Trapped");
                }
                */
            }
            Console.ReadLine();
        }
    }
}
