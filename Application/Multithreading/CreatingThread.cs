using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Multithreading
{
    class CreatingThread
    {
        /* Threads are created by extending the Thread class */
        /* The extended Thread class then calls the Start() method to begin the child thread execution */

        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }
        public static void Example()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
    }
}
