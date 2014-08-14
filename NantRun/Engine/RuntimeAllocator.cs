using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NantRun.Document.Components;
using NantRun.Document.Components.Items;
using Runner;

namespace NantRun.Engine
{
    public delegate void RemoveFromQueueDelegate(object sender, RemoveFromQueueEventArgs e);
    public class RuntimeAllocator
    {
       
        private const int maxRunners = 5;
        public event RemoveFromQueueDelegate RemoveFromQueueEvent;
        
        
        public bool AddedNew = false;

        System.Collections.ObjectModel.Collection<ManualResetEvent> doneEvents = 
            new System.Collections.ObjectModel.Collection<ManualResetEvent>();

        private Collection<TargetRunner> targetRunners = new Collection<TargetRunner>();

        public Collection<Target> Target { get; set; }
        public Collection<Parameter> Parameter { get; set; }

        private const uint TEN_MINUTES = 600000;

        public RuntimeAllocator()
        {
            this.RemoveFromQueueEvent += RuntimeAllocator_RemoveFromQueueEvent;
        }

        public void Run()
        {
            while(true)
            {
                if(AddedNew)
                {
                    CreateRunner(Target, Parameter);
                    AddedNew = false;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }


        public void Run(Collection<Target> targetName, Collection<Parameter> parameters)
        {
            CreateRunner(targetName, parameters);
        }


        public bool StartSuccessful { get; set; }
        public int RunnersCreated{ get; set;}

        private void CreateRunner(Collection<Target> target, Collection<Parameter> param)
        {
            try
            {
                ManualResetEvent resetEvent = new ManualResetEvent(false);
                TextConsole console = new TextConsole();
                //console.Show();
                //ThreadStart consoleThreadStart = console.Show;
                //Thread consoleThread = new Thread(consoleThreadStart);
                //consoleThread.IsBackground = true;
                //consoleThread.Start();
                doneEvents.Add(resetEvent);
                TargetRunner runner = new TargetRunner(target, param, null, resetEvent);
                targetRunners.AddItem(runner);
                ThreadPool.QueueUserWorkItem(runner.ThreadPoolCallback, targetRunners.Count - 1);
                //ThreadPool.SetMaxThreads(maxRunners, maxRunners);
                //WaitOrTimerCallback waitOrTimerCallback = runner.ThreadPoolCallback;
                //ThreadPool.RegisterWaitForSingleObject(resetEvent, waitOrTimerCallback, targetRunners, TEN_MINUTES, true);
                WaitHandle.WaitAny(doneEvents.ToArray());
                //RemoveItemFromQueue(targetRunners.Count - 1);
                OnRemoveFromQueueEvent(runner, new RemoveFromQueueEventArgs(targetRunners.Count - 1));
            
            }
            catch
            {
            }
        }

        protected virtual void OnRemoveFromQueueEvent(object sender, RemoveFromQueueEventArgs e)
        {
            RemoveFromQueueEvent(sender, e);
        }


        void RuntimeAllocator_RemoveFromQueueEvent(object sender, RemoveFromQueueEventArgs e)
        {
            try
            {
                lock (this)
                {
                    int index = (int)e.State;
                    TargetRunner runner = (TargetRunner)sender;
                    //targetRunners.RemoveItem(targetRunners.ElementAt(index));
                    targetRunners.RemoveItem(runner);
                    doneEvents.RemoveAt(index);
                }
            }
            catch { }
        }
    }


    public class RemoveFromQueueEventArgs : EventArgs
    {
        public object State{ get; set; }
        public RemoveFromQueueEventArgs(object state)
        {
            this.State = state;
        }
    }
    
}
