using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Variables
{
    class Constant
    {
        /*
         * Constant is an immutable value.
         * 
         * 
         * 
         */

        void Declaration()
        {
#pragma warning disable 219
            /*
                syntax
                const data_type variable_name = constant_value;

                Constants are declared using "const" keyword

                We can not define a constant wothout setting up its value
                const float Pi;     this is an error as it is uninitialized                
            */
            const float Pi = 3.14f;

            /*
                We can not modify a constant anywhere in the program
                Pi    = 50.1f;      this is not allowed, constants can not be modified
            */
            const int Hundred = 100;
#pragma warning restore 219
        }

        void Initialization()
        {
            /*
             * Constants are initialized along with declaration
             * You can not declare any constant without initializing it.
             */
        }
        static void Example()
        {
            Constant constant = new Constant();
            constant.Declaration();
            constant.Initialization();
        }
    }
}
