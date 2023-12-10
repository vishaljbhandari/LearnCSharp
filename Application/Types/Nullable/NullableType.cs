using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Nullable
{
    class NullableType
    {
        /*
         * C# provides a special data types, the nullable types, 
         * to which you can assign normal range of values as well as null values.
         */

        /*
            < data_type> ? <variable_name> = null;
        */

        public static void Example()
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
        }
    }
}
