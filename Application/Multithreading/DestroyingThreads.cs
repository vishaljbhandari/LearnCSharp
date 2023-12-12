using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Multithreading
{
    class DestroyingThreads
    {
        /* The Abort() method is used for destroying threads */

        /*
         * The runtime aborts the thread by throwing a ThreadAbortException. 
         * This exception cannot be caught, the control is sent to the finally block, if any.
         * 
         */
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");

                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception {0}", e.Data);
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
        public static void Example()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref);
            childThread.Start();

            //stop the main thread for some time
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");

#pragma warning disable SYSLIB0006 // Type or member is obsolete
            childThread.Abort();
#pragma warning restore SYSLIB0006 // Type or member is obsolete
        }
    }
}
