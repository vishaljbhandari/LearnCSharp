using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.Attributes.PredefinedAttributes
{
    class CAttributeUsage
    {
        /* The pre-defined attribute AttributeUsage describes how a custom attribute class can be used. */
        [AttributeUsage(
           validon,
           AllowMultiple = allowmultiple,
           Inherited = inherited
        )]
        [AttributeUsage(
           AttributeTargets.Class |
           AttributeTargets.Constructor |
           AttributeTargets.Field |
           AttributeTargets.Method |
           AttributeTargets.Property,
           AllowMultiple = true)]
        public static void Example()
        {
            CAttributeUsage obj = new CAttributeUsage();

        }
    }
}
