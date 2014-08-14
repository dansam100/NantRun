using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace NantRun.Engine
{
    public class TargetRunner
    {
        public ManualResetEvent doneEvent = null;
        
        public TargetRunner(string targetName, string parameters, ManualResetEvent doneEvent)
        {
            this.doneEvent = doneEvent;
        }

        public TargetRunner()
        {
        }

        // Wrapper method for use with thread pool.
        public void ThreadPoolCallback(Object threadContext)
        {
            int threadIndex = (int)threadContext;
            /*
            Console.WriteLine("thread {0} started...", threadIndex);
            _fibOfN = Calculate(_n);
            Console.WriteLine("thread {0} result calculated...", threadIndex);
            _doneEvent.Set();*/
        }
    }
}
