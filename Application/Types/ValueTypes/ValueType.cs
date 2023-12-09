using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.ValueTypes
{
    class CValueType
    {
        public static void Example()
        {
            BoolType.Example();
            CharType.Example();
            {
                ByteType.Example();
                SByteType.Example();

                IntType.Example();
                UIntType.Example();

                ShortType.Example();
                UShortType.Example();

                LongType.Example();
                ULongType.Example();

                DecimalType.Example();
            }
            {
                FloatType.Example();
                DoubleType.Example();
            }
        }
    }
}
