using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Generic Delegates
    You can define a generic delegate with type parameters.For example −

    delegate T NumberChanger<T>(T n);
*/
delegate T NumberChanger<T>(T n);
namespace Generics
{
    class TestDelegate {
        static int num = 10;

        public static int AddNum(int p) {
            num += p;
            return num;
        }
        public static int MultNum(int q) {
            num *= q;
            return num;
        }
        public static int getNum() {
            return num;
        }
        public static void Run() {
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
        }
    }
}