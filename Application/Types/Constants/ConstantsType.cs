using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Constants
{
    class ConstantsType
    {
        /*
         * Constant/literals
         * Fixed values that the program may not alter during its execution
         * The constants are treated just like regular variables except that their values cannot be modified after their definition.
         */

        void DefininingConstant()
        {
            /*
                Defining Constants
                Constants are defined using the const keyword. Syntax for defining a constant is −

                const <data_type> <constant_name> = value;
             */
            const double pi = 3.14159;

            // pi = 54.25;      // Error, compile time error, can not modify a constant

            double radius = 5.6;
            double areaCircle = pi * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1}", radius, areaCircle);
        }

        public static void Example()
        {
            ConstantsType obj = new ConstantsType();
            obj.DefininingConstant();


            CharacterLiteral.Example();
            ConstantsType.Example();
            FloatingPointLiteral.Example();
            StringLiteral.Example();
        }
    }
}
