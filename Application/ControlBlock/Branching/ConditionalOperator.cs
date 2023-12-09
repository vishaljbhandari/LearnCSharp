using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControlBlock.Branching
{
    class ConditionalOperator
    {
        void condionalOperator()
        {
            int first = 5;
            int second = 10;
            int result = first > second ? 1 : 0;
            Console.WriteLine("first = {0}", first);
            Console.WriteLine("second = {0}", second);
            Console.WriteLine("result = first > second ? 1 : 0 = {0}", result);
        }
        public static void Example()
        {
            ConditionalOperator obj = new ConditionalOperator();
            obj.condionalOperator();
        }
    }
}
