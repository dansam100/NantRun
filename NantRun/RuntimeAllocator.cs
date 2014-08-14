using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NantRun.Document.Components;

namespace NantRun.Engine
{
    public class RuntimeAllocator
    {
       
        private const int maxRunners = 5;

        System.Collections.ObjectModel.Collection<ManualResetEvent> doneEvents = 
            new System.Collections.ObjectModel.Collection<ManualResetEvent>();

        private Collection<TargetRunner> targetRunners = new Collection<TargetRunner>();
        private const uint TEN_MINUTES = 600000;


        public void Run(string targetName, string parameters)
        {
            CreateRunner(targetName, parameters);
        }


        public bool StartSuccessful { get; set; }
        public int RunnersCreated{ get; set;}

        private void CreateRunner(string target, string param)
        {
            try
            {
                ManualResetEvent resetEvent = new ManualResetEvent(false);
                doneEvents.Add(resetEvent);
                TargetRunner runner = new TargetRunner(target, param, resetEvent);
                targetRunners.AddItem(runner);
                //ThreadPool.QueueUserWorkItem(runner.ThreadPoolCallback, targetRunners.Count - 1);
                ThreadPool.SetMaxThreads(maxRunners, maxRunners);
                WaitOrTimerCallback waitOrTimerCallback = RemoveItemFromQueue;
                ThreadPool.RegisterWaitForSingleObject(resetEvent, waitOrTimerCallback, targetRunners, TEN_MINUTES, true);
                //WaitHandle.WaitAny(doneEvents.ToArray());
            }
            catch
            {
            }
        }

        private void RemoveItemFromQueue(object state, bool timedOut)
        {
            try
            {
                int index = (int) state;
                targetRunners.RemoveItem(targetRunners.ElementAt(index));
                doneEvents.RemoveAt(index);
            }
            catch{}
        }


    }


    
}
