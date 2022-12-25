using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Preprocessor
{
    class Pragma
    {
        void PragmaOnce()
        {

        }
        void PragmaWarning()
        {
            // For Controling any compiler warning

            // Example warning CS0219, The variable 'xx' is assigned but its value is never used
#pragma warning disable 219 // supressing warning CS0219
            int var = 5;
#pragma warning restore 219 // restoring warning CS0219

            // Example warning CS0168: The variable 'xx' is declared but never used
#pragma warning disable 168 // supressing warning CS0168
            int data;
#pragma warning restore 168 // restoring warning CS0168

            // Example warning CS0219 and CS0168 controlling together
#pragma warning disable 219, 168 // supressing warning CS0219, CS0168
            int x;
            int y = 5;
#pragma warning restore 219, 168 // restoring warning CS0219, CS0168
        }
    }
}
