using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {

        static void variables()
        {
            // <data_type> <variable_list>; // Declaration
            // variable_name = value;   // Assignment
            // <data_type> <variable_name> = value; // Declaration & Assignment

            short a;
            int b;
            double c;

            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            int convertedInteger;
            convertedInteger = Convert.ToInt32(Console.ReadLine());     // Console.ReadLine() accepts and returns the data in string format
            Console.WriteLine("convertedInteger = ", convertedInteger);


            // lvalue − An expression that is an lvalue may appear as either the left-hand or right-hand side of an assignment.
            // rvalue − An expression that is an rvalue may appear on the right - but not left-hand side of an assignment.

            // Variables are lvalues and hence they may appear on the left-hand side of an assignment. 
            // Numeric literals are rvalues and hence they may not be assigned and can not appear on the left-hand side

            int g = 20; // Allowed
            // 10 = 20; // Not Allowed
        }

        static void literals()
        {
            /*  - Integer Literals
                212         Legal 
                215u         Legal 
                0xFeeL       Legal
                85          decimal 
                0x4b        hexadecimal 
                30          int 
                30u         unsigned int 
                30l        long 
                30ul        unsigned long 
            */

            /*  - Floating Literals
                3.14159       Legal
                314159E-5F    Legal
                510E          Illegal: incomplete exponent
                210f          Illegal: no decimal or exponent
                .e55          Illegal: missing integer or fraction
            */

            /*  - Character Literals - Escape Sequence 
                \\	\ character
                \'	' character
                \"	" character
                \?	? character
                \a Alert or bell
                \b Backspace
                \f Form feed
                \n Newline
                \r Carriage return
                \t Horizontal tab
                \v Vertical tab
                \xhh. . .Hexadecimal number of one or more digits
            */

            /*  - String Literals
                "hello, dear"

                "hello, \
                dear"
                
                "hello, " "d" "ear"
                
                @"hello dear"
            */


            const double pi = 3.14159;

            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
        }

        static void Main(string[] args)
        {
            variables();

            literals();

            Console.ReadLine();
        }
    }
}
