using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Branching
{
    class SwitchStatement
    {
        /*
         * A switch statement allows a variable to be tested for equality against a list of values. 
         * Each value is called a case, and the variable being switched on is checked for each switch case.
         */

        void switchStatement()
        {
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
                /* we can have any number of case statements */
                default:    /* Optional */
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
        }
        void nestedSwitchStatement()
        {
            /*
             * It is possible to have a switch as part of the statement sequence of an outer switch. 
             * Even if the case constants of the inner and outer switch contain common values, no conflicts will arise
             */
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
        public static void Example()
        {
            SwitchStatement obj = new SwitchStatement();
            obj.switchStatement();
            obj.nestedSwitchStatement();
        }
    }
}
