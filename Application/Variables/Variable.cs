using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Variables
{
    class Variable
    {
        /*
         * Variable is a name given to a storage location in memory
         * 
         * 
         * 
         */
        void Declaration()
        {
            /* <data_type> <variable_list>; without initialization */

#pragma warning disable 219, 168
            int UnInitializedNumber;
            int InitializedNumber = 5;

            float marks = 5.4f;
            char choice = 'C';
#pragma warning restore 219, 168
        }

        void Initialization()
        {
            /* <data_type> <variable_list> = value; declaration with initialization */
            int d = 3, f = 5;    /* initializing d and f. */
            byte z = 22;         /* initializes z. */
            double pi = 3.14159; /* declares an approximation of pi. */
            char x = 'x';        /* the variable x has the value 'x'. */

            /* Variables are initialized (assigned a value) with an equal sign followed by a constant expression */
            /* variable_name = value; */
            char j;
            j = 'x';
            d = f;
            j = x;
            Console.WriteLine("Pi {0}", pi);
            Console.WriteLine("z {0}", z);
            /* values can be initialized using user input as well */
            /* The Console class in the System namespace provides a function ReadLine() for accepting input from the user and store it into a variable s*/
            int num;
            num = Convert.ToInt32(Console.ReadLine());
        }
        void lvalues()
        {
            /* Variables are lvalues and hence they may appear on the left-hand side of an assignment */
            int g = 20;
            Console.WriteLine("g {0}", g);
        }
        static void Example()
        {
            Variable obj = new Variable();
            obj.Declaration();
            obj.Initialization();
            obj.lvalues();
        }
    }
}