using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Multithreading
{
    public class MYThread
    {

        // Non-Static method
        public void mythr1()
        {
            Console.WriteLine("1st thread is Working..!!");
            Thread.Sleep(100);
        }

        // Non-Static method
        public void mythr2()
        {
            Console.WriteLine("2nd thread is Working..!!");
        }
    }
    class ThreadClass
    {
        public static void work()
        {
            Thread.Sleep(1000);
        }

        [Obsolete]
        void threadClassProperties()
        {
            /*	
                CurrentContext
                Gets the current context in which the thread is executing.

                CurrentCulture
                Gets or sets the culture for the current thread.
	
                CurrentPrinciple
                Gets or sets the thread's current principal (for role-based security).

                CurrentThread
                Gets the currently running thread.

                CurrentUICulture
                Gets or sets the current culture used by the Resource Manager to look up culture-specific resources at run-time.

                ExecutionContext
                Gets an ExecutionContext object that contains information about the various contexts of the current thread.

                IsAlive
                Gets a value indicating the execution status of the current thread.

                IsBackground
                Gets or sets a value indicating whether or not a thread is a background thread.

                IsThreadPoolThread
                Gets a value indicating whether or not a thread belongs to the managed thread pool.

                ManagedThreadId
                Gets a unique identifier for the current managed thread.

                Name
                Gets or sets the name of the thread.

                Priority
                Gets or sets a value indicating the scheduling priority of a thread.


                ThreadState
                Gets a value containing the states of the current thread.
             */
            // Creating and initializing threads
            Thread thread1 = new Thread(work);
            Thread thread2 = new Thread(work);
            Thread thread3 = new Thread(work);

            // Set the priority of threads
            thread2.Priority = ThreadPriority.Lowest;
            thread3.Priority = ThreadPriority.AboveNormal;
            thread1.Start();
            thread2.Start();
            thread3.Start();

            // Display the priority of threads
            Console.WriteLine("The Priority of Thread 1 is: {0}", thread1.Priority);
            Console.WriteLine("The Name of Thread 1 is: {0}", thread1.Name);
            Console.WriteLine("The ManagedThreadId of Thread 1 is: {0}", thread1.ManagedThreadId);
            Console.WriteLine("The IsAlive of Thread 1 is: {0}", thread1.IsAlive);
            Console.WriteLine("The ExecutionContext of Thread 1 is: {0}", thread1.ExecutionContext);
            Console.WriteLine("The IsBackground of Thread 1 is: {0}", thread1.IsBackground);
            Console.WriteLine("The ApartmentState of Thread 1 is: {0}", thread1.ApartmentState);
            Console.WriteLine("The CurrentCulture of Thread 1 is: {0}", thread1.CurrentCulture);

            Console.WriteLine("The priority of Thread 2 is: {0}", thread2.Priority);

            Console.WriteLine("The priority of Thread 3 is: {0}", thread3.Priority);
        }
        void threadClassMethods()
        {
            // Creating instance of MYThread class
            MYThread obj = new MYThread();

            // Creating and initializing threads
            Thread T1 = new Thread(new ThreadStart(obj.mythr1));
            Thread T2 = new Thread(new ThreadStart(obj.mythr2));
            T1.Start();

            // Join thread
            T1.Join();
            T2.Start();
        }

        [Obsolete]
        public static void Example()
        {
            ThreadClass obj = new ThreadClass();
            obj.threadClassProperties();
            obj.threadClassMethods();

        }
    }
}
