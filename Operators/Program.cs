using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Arithmatic Operators
                int a = 21;
                int b = 10;
                int c;

                c = a + b;
                Console.WriteLine("Line 1 - Value of c is {0}", c);

                c = a - b;
                Console.WriteLine("Line 2 - Value of c is {0}", c);

                c = a * b;
                Console.WriteLine("Line 3 - Value of c is {0}", c);

                c = a / b;
                Console.WriteLine("Line 4 - Value of c is {0}", c);

                c = a % b;
                Console.WriteLine("Line 5 - Value of c is {0}", c);

                c = a++;
                Console.WriteLine("Line 6 - Value of c is {0}", c);

                c = a--;
                Console.WriteLine("Line 7 - Value of c is {0}", c);
            }

            {
                // Relational Operators

                int a = 21;
                int b = 10;

                if (a == b)
                {
                    Console.WriteLine("Line 1 - a is equal to b");
                }
                else
                {
                    Console.WriteLine("Line 1 - a is not equal to b");
                }

                if (a < b)
                {
                    Console.WriteLine("Line 2 - a is less than b");
                }
                else
                {
                    Console.WriteLine("Line 2 - a is not less than b");
                }

                if (a > b)
                {
                    Console.WriteLine("Line 3 - a is greater than b");
                }
                else
                {
                    Console.WriteLine("Line 3 - a is not greater than b");
                }

                /* Lets change value of a and b */
                a = 5;
                b = 20;

                if (a <= b)
                {
                    Console.WriteLine("Line 4 - a is either less than or equal to  b");
                }

                if (b >= a)
                {
                    Console.WriteLine("Line 5-b is either greater than or equal to b");
                }
            }
            {
                // Logical Operators

                bool a = true;
                bool b = true;

                if (a && b)
                {
                    Console.WriteLine("Line 1 - Condition is true");
                }

                if (a || b)
                {
                    Console.WriteLine("Line 2 - Condition is true");
                }

                /* lets change the value of  a and b */
                a = false;
                b = true;

                if (a && b)
                {
                    Console.WriteLine("Line 3 - Condition is true");
                }
                else
                {
                    Console.WriteLine("Line 3 - Condition is not true");
                }

                if (!(a && b))
                {
                    Console.WriteLine("Line 4 - Condition is true");
                }   
            }

            {
                // Bitwise Operator
                int a = 60;            /* 60 = 0011 1100 */
                int b = 13;            /* 13 = 0000 1101 */
                int c = 0;

                c = a & b;             /* 12 = 0000 1100 */
                Console.WriteLine("Line 1 - Value of c is {0}", c);

                c = a | b;             /* 61 = 0011 1101 */
                Console.WriteLine("Line 2 - Value of c is {0}", c);

                c = a ^ b;             /* 49 = 0011 0001 */
                Console.WriteLine("Line 3 - Value of c is {0}", c);

                c = ~a;                /*-61 = 1100 0011 */
                Console.WriteLine("Line 4 - Value of c is {0}", c);

                c = a << 2;      /* 240 = 1111 0000 */
                Console.WriteLine("Line 5 - Value of c is {0}", c);

                c = a >> 2;      /* 15 = 0000 1111 */
                Console.WriteLine("Line 6 - Value of c is {0}", c);
            }
            {
                // Assignment Operator
                int a = 21;
                int c;
                c = a;
                Console.WriteLine("Line 1 - =  Value of c = {0}", c);

                c += a;
                Console.WriteLine("Line 2 - += Value of c = {0}", c);

                c -= a;
                Console.WriteLine("Line 3 - -=  Value of c = {0}", c);

                c *= a;
                Console.WriteLine("Line 4 - *=  Value of c = {0}", c);

                c /= a;
                Console.WriteLine("Line 5 - /=  Value of c = {0}", c);

                c = 200;
                c %= a;
                Console.WriteLine("Line 6 - %=  Value of c = {0}", c);

                c <<= 2;
                Console.WriteLine("Line 7 - <<=  Value of c = {0}", c);

                c >>= 2;
                Console.WriteLine("Line 8 - >>=  Value of c = {0}", c);

                c &= 2;
                Console.WriteLine("Line 9 - &=  Value of c = {0}", c);

                c ^= 2;
                Console.WriteLine("Line 10 - ^=  Value of c = {0}", c);

                c |= 2;
                Console.WriteLine("Line 11 - |=  Value of c = {0}", c);
            }
            {
                // Misc Operators

                /* example of sizeof operator */
                Console.WriteLine("The size of int is {0}", sizeof(int));
                Console.WriteLine("The size of short is {0}", sizeof(short));
                Console.WriteLine("The size of double is {0}", sizeof(double));

                /* example of ternary operator */
                int a, b;
                a = 10;
                b = (a == 1) ? 20 : 30;
                Console.WriteLine("Value of b is {0}", b);

                b = (a == 10) ? 20 : 30;
                Console.WriteLine("Value of b is {0}", b);
            }
            {
                // Opeartor Precedance

                int a = 20;
                int b = 10;
                int c = 15;
                int d = 5;
                int e;
                e = (a + b) * c / d;     // ( 30 * 15 ) / 5
                Console.WriteLine("Value of (a + b) * c / d is : {0}", e);

                e = ((a + b) * c) / d;   // (30 * 15 ) / 5
                Console.WriteLine("Value of ((a + b) * c) / d is  : {0}", e);

                e = (a + b) * (c / d);   // (30) * (15/5) {0}", e);

                e = a + (b * c) / d;    //  20 + (150/5) {0}", e);
            }

            Console.ReadLine();
        }
    }
}
