using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Multithreading
{
    class MultiThreadings
    {
        [Obsolete]
        public static void Example()
        {
            Threading.Example();
            ThreadClass.Example();
            ThreadLifeCycle.Example();
            CreatingThread.Example();
            MainThread.Example();
            SleepThreads.Example();
            ChildThread.Example();
            DestroyingThreads.Example();
        }
    }
}
