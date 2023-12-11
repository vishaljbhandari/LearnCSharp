using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.StaticMembers
{
    class StaticExamples
    {
        public static int num;

        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class Statics
    {
        /* 
         * 
         * only one instance of the member exists for a class
         * define class members as static using the static keyword
         * 
         * 
         * Can be initialized outside the member function or class definition. 
         * Can be initialized inside the class definition
         * 
         * Usually, used for defining constants
         */
        public static void Example()
        {
            StaticExamples s1 = new StaticExamples();
            StaticExamples s2 = new StaticExamples();

            s1.count();
            s1.count();
            s1.count();

            s2.count();
            s2.count();
            s2.count();

            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
        }
    }
}
