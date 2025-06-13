using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.Attributes.PredefinedAttributes
{
    class CAttributeUsage
    {
        /*  The pre-defined attribute AttributeUsage describes how a custom attribute class can be used. 
            It specifies the types of items to which the attribute can be applied.

             Syntax for specifying this attribute is as follows −

            [AttributeUsage (
               validon,
               AllowMultiple = allowmultiple,
               Inherited = inherited
            )]

            Where,

            The parameter validon specifies the language elements on which the attribute can be placed. 
                It is a combination of the value of an enumerator AttributeTargets. The default value is AttributeTargets.All.

            The parameter allowmultiple (optional) provides value for the AllowMultiple property of this attribute, a Boolean value. 
                If this is true, the attribute is multiuse. The default is false (single-use).

            The parameter inherited (optional) provides value for the Inherited property of this attribute, a Boolean value. 
                If it is true, the attribute is inherited by derived classes. The default value is false (not inherited).

        [AttributeUsage(
           AttributeTargets.Class |
           AttributeTargets.Constructor |
           AttributeTargets.Field |
           AttributeTargets.Method |
           AttributeTargets.Property,
           AllowMultiple = true)]

         */

        public static void Example()
        {
            CAttributeUsage obj = new CAttributeUsage();

        }
    }
}
