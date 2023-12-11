#define PI
#define FI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Preprocessor
{
    class Define
    {
        void definePreprocessor()
        {
            /* #define
                    It defines a sequence of characters, called symbol

                    #define symbol
                    #define PI

                #undef
                    It allows you to undefine a symbol
                
                    #undef symbol
                    #undef PI

                Cannot define/undefine preprocessor symbols after first token in file
            */
        }
        public static void Example()
        {
            Define obj = new Define();
            obj.definePreprocessor();
        }
    }
}
