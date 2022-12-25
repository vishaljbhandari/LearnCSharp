using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/* 
A thread is defined as the execution path of a program.
Each thread defines a unique flow of control.

Threads are lightweight processes. Threads are used for implementation of concurrent programming, Use of threads saves wastage of CPU cycle and increase efficiency of an application.

Thread Life Cycle of a thread
    starts when an object of the System.Threading.Thread class is created
    ends when the thread is terminated or completes execution

States in the life cycle of a thread −

The Unstarted State − It is the situation when the instance of the thread is created but the Start method is not called.

The Ready State − It is the situation when the thread is ready to run and waiting CPU cycle.

The Not Runnable State − A thread is not executable, when
    Sleep method has been called
    Wait method has been called
    Blocked by I/O operations
The Dead State − It is the situation when the thread completes execution or is aborted.

*/


namespace Multithreading
{
    class Program
    {
        public static void CallToChildThread1()
        {
            Console.WriteLine("Child thread starts");
        }

        public static void CallToChildThread2()
        {
            Console.WriteLine("Child thread starts");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        public static void CallToChildThread3()
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
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        static void Main(string[] args)
        {
            {   // Main Thread
                Thread th = Thread.CurrentThread;
                th.Name = "MainThread";

                Console.WriteLine("This is {0}", th.Name);
                Console.ReadLine();

                ThreadStart childref1 = new ThreadStart(CallToChildThread1);
                Console.WriteLine("In Main: Creating the Child thread 1");
                Thread childThread1 = new Thread(childref1);
                childThread1.Start();
                Console.ReadLine();

                ThreadStart childref2 = new ThreadStart(CallToChildThread2);
                Console.WriteLine("In Main: Creating the Child thread 2");

                Thread childThread2 = new Thread(childref2);
                childThread2.Start();
                Console.ReadLine();


                ThreadStart childref3 = new ThreadStart(CallToChildThread3);
                Console.WriteLine("In Main: Creating the Child thread 3");

                Thread childThread3 = new Thread(childref3);
                childThread3.Start();

                //stop the main thread for some time
                Thread.Sleep(2000);

                //now abort the child
                Console.WriteLine("In Main: Aborting the Child thread 3");

                childThread3.Abort();
                Console.ReadLine();
            }
        }
    }
}
