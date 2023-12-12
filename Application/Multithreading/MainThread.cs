using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Multithreading
{
    class MainThread
    {
        /*
         * The first thread to be executed in a process is called the main thread
         * 
         * When a C# program starts execution, the main thread is automatically created. 
         */

        public static void Example()
        {
            /* This is still main thread */
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);
        }
    }
}
