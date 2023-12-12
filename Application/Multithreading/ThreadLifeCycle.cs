using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Multithreading
{
    class ThreadLifeCycle
    {
        /*
         * The life cycle of a thread 
         *  starts when an object of the System.Threading.Thread class is created 
         *  and ends when the thread is terminated or completes execution
         * 
         */

        /*
         * The Unstarted State
         *      It is the situation when the instance of the thread is created but the Start method is not called.
         */


        /*
         * The Ready State
         *      It is the situation when the thread is ready to run and waiting CPU cycle.
         */

        /*
         * The Not Runnable State − A thread is not executable, when
                Sleep method has been called
                Wait method has been called
                Blocked by I/O operations
         */

        /*
         * The Dead State
         *      It is the situation when the thread completes execution or is aborted.
         */

        public static void Example()
        {
        }
    }
}
