using System;
using System.Threading;

namespace ThreadSample
{
    public class ThreadJoinSampleClass
    {
        private static Thread _thread1, _thread2;

        public static void RunSample()
        {
            _thread1 = new Thread(RunThreadProcess) { Name = "Thread 1" };
            _thread1.Start();

            _thread2 = new Thread(RunThreadProcess) { Name = "Thread 2" };
            _thread2.Start();
        }

        private static void RunThreadProcess()
        {
            Console.WriteLine($"Current thread name - {Thread.CurrentThread.Name}");
            if (Thread.CurrentThread.Name == "Thread 1" && _thread2.ThreadState != ThreadState.Unstarted)
            {
                _thread2.Join();
            }

            Thread.Sleep(5000);

            Console.WriteLine($"Current thread name - {Thread.CurrentThread.Name}");
            Console.WriteLine($"Thread 1 state- {_thread1.ThreadState}");
            Console.WriteLine($"Thread 2 state- {_thread2.ThreadState}");
        }
    }
}