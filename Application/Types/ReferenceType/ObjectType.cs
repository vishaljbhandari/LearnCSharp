using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.ReferenceType
{
    class ObjectType
    {
        /*
         * The Object Type is the ultimate base class for all data types in C# Common Type System (CTS)
         * Object is an alias for System.Object class
         * The object types can be assigned values of any other types, value types, reference types, predefined or user-defined types. 
         *      However, before assigning values, it needs type conversion.
         * 
         * When a value type is converted to object type, it is called boxing
         * when an object type is converted to a value type, it is called unboxing
         * 
         */

        public static void Example()
        {
            object obj;
            obj = 100; // this is boxing
        }
    }
}
