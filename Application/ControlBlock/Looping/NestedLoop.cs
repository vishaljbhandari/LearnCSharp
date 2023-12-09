using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Looping
{
    class NestedLoop
    {
        void nestedLoops()
        {
            /*
             * C# allows to use one loop inside another loop
             */
            {
                // nested for loop
                int i, j;

                for (i = 2; i < 100; i++)
                {
                    for (j = 2; j <= (i / j); j++)
                    {
                        if ((i % j) == 0) break; // if factor found, not prime
                    }
                    if (j > (i / j))
                    {
                        Console.WriteLine("{0} is prime", i);
                    }
                }
            }
            {
                // nested do while loop
                int i = 0, j = 0;
                do
                {
                    Console.WriteLine("i -> {0}, j -> {1}", i, j);
                    do
                    {
                        Console.WriteLine("i -> {0}, j -> {1}", i, j);
                        j++;
                    }
                    while (j <= (i / j));
                    i++;
                }
                while (i < 100);
            }
            {
                // nested while loop
                int i = 0, j = 0;
                while (i < 100)
                {
                    Console.WriteLine("i -> {0}, j -> {1}", i, j);
                    while (j <= (i / j))
                    {
                        Console.WriteLine("i -> {0}, j -> {1}", i, j);
                        j++;
                    }                    
                    i++;
                }                
            }
        }
        public static void Example()
        {
            NestedLoop obj = new NestedLoop();
            obj.nestedLoops();
        }
    }
}
