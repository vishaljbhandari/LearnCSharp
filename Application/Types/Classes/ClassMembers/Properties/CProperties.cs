using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.ClassMembers.Properties
{
    class CProperties
    {
        /*
         * Properties are named members of classes, structures, and interfaces
         * Member variables or methods in a class or structures are called Fields. 
         * Properties are an extension of fields and are accessed using the same syntax. 
         * They use accessors through which the values of the private fields can be read, written or manipulated.
         * 
         * Properties do not name the storage locations.
         * Instead, they have accessors that read, write, or compute their values
         */
        public static void Example()
        {
            AccessorsProperties.Example();
            AbstractProperties.Example();
            AutoImplementedProperty.Example();
            ReadOnlyProperties.Example();
            WriteOnlyProperties.Example();
            PropertyValidation.Example();
        }
    }
}
