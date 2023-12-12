using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Declaratives.Attributes.CustomBuiltAttributes
{
    namespace CustomAttributeDeclaring
    {
        /* A new custom attribute should is derived from the System.Attribute class */
    }
    namespace CustomAttributeConstructing
    {
        /*  */
    }
    namespace CustomAttributeApplying
    {
        /* The attribute is applied by placing it immediately before its target */
    }
    class CustomAttribute
    {
        public static void Example()
        {
            CustomAttribute obj = new CustomAttribute();
        }
    }
}
