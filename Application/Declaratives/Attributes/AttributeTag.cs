using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.Attributes
{
    class AttributeTag
    {
        /* An attribute 
         *  is a declarative tag
         *  used to convey information to runtime about the behaviors of various elements like classes, methods, structures, enumerators, assemblies etc
         *  
         *  
         *  You can add declarative information to a program by using an attribute. 
         *  A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.
         *  Attributes are used for 
         *      adding metadata
         *      compiler instruction
         *      comments, description, methods and classes to a program
         *      
         *  The .Net Framework provides two types of attributes: 
         *      pre-defined attributes 
         *      custom built attributes
         * */

        void specifyingAttributes()
        {
            /*
                [attribute(positional_parameters, name_parameter = value, ...)]
                element

                Name of the attribute and its values are specified within the square brackets, before the element to which the attribute is applied
                    Positional parameters specify the essential information 
                    name parameters specify the optional information
            */
            /*
             *  Predefined Attributes 
             *      The .Net Framework provides three pre-defined attributes
             *      1. AttributeUsage
             *      2. Conditional
             *      3. Obsolete
             */
        }


        public static void Example()
        {
            AttributeTag obj = new AttributeTag();
            obj.specifyingAttributes();
        }
    }
}
