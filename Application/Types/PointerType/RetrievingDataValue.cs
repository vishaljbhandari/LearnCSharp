using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.PointerType
{
    class RetrievingDataValue
    {
        /* You can retrieve the data stored at the located referenced by the pointer variable, using the ToString() method */
        void retrievingDataValue()
        {
            unsafe
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Data is: {0} ", p->ToString());
                Console.WriteLine("Address is: {0} ", (int)p);
            }
        }
        public static void Example()
        {
            RetrievingDataValue obj = new RetrievingDataValue();
            obj.retrievingDataValue();
        }
    }
}
