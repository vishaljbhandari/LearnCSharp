using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /* local variable definition */
                int a = 10;

                /* check the boolean condition using if statement */
                if (a < 20)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("a is less than 20");
                }
                Console.WriteLine("value of a is : {0}", a);
            }

            {
                /* local variable definition */
                int a = 100;

                /* check the boolean condition */
                if (a < 20)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("a is less than 20");
                }
                else
                {
                    /* if condition is false then print the following */
                    Console.WriteLine("a is not less than 20");
                }
                Console.WriteLine("value of a is : {0}", a);
            }

            {
                /* local variable definition */
                int a = 100;

                /* check the boolean condition */
                if (a == 10)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("Value of a is 10");
                }
                else if (a == 20)
                {
                    /* if else if condition is true */
                    Console.WriteLine("Value of a is 20");
                }
                else if (a == 30)
                {
                    /* if else if condition is true  */
                    Console.WriteLine("Value of a is 30");
                }
                else
                {
                    /* if none of the conditions is true */
                    Console.WriteLine("None of the values is matching");
                }
                Console.WriteLine("Exact value of a is: {0}", a);
            }

            {
                //* local variable definition */
                int a = 100;
                int b = 200;

                /* check the boolean condition */
                if (a == 100)
                {

                    /* if condition is true then check the following */
                    if (b == 200)
                    {
                        /* if condition is true then print the following */
                        Console.WriteLine("Value of a is 100 and b is 200");
                    }
                }
                Console.WriteLine("Exact value of a is : {0}", a);
                Console.WriteLine("Exact value of b is : {0}", b);
            }


            {
                // Switch Case
                /* local variable definition */
                char grade = 'B';

                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Excellent!");
                        break;
                    case 'B':
                    case 'C':
                        Console.WriteLine("Well done");
                        break;
                    case 'D':
                        Console.WriteLine("You passed");
                        break;
                    case 'F':
                        Console.WriteLine("Better try again");
                        break;
                    default:
                        Console.WriteLine("Invalid grade");
                        break;
                }
                Console.WriteLine("Your grade is  {0}", grade);
            }

            {
                // Nested Switch Case
                int a = 100;
                int b = 200;

                switch (a)
                {
                    case 100:
                        Console.WriteLine("This is part of outer switch ");

                        switch (b)
                        {
                            case 200:
                                Console.WriteLine("This is part of inner switch ");
                                break;
                        }
                        break;
                }
                Console.WriteLine("Exact value of a is : {0}", a);
                Console.WriteLine("Exact value of b is : {0}", b);
            }

            {
                // Ternary Operator
                int x = 20, y = 10;

                var result = x > y ? "x is greater than y" : "x is less than y";

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
