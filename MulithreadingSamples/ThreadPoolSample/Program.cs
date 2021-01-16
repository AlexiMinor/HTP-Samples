using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ThreadPoolSample
{
    class Program
    {
      

        static void Main(string[] args)
        {
         
            //var sw = new Stopwatch();

            //Console.WriteLine("TP Execution");
            //sw.Start();
            //ProcessWithTheadPoolMethod();
            //sw.Stop();
            //Console.WriteLine($"Time consumed by Process with ThreadPool is :{sw.ElapsedTicks}");

            //sw.Reset();

            //Console.WriteLine("Thead Execution");
            //sw.Start();
            //ProcessWithTheadMethod();
            //sw.Stop();
            //Console.WriteLine($"Time consumed by Process with Thread is :{sw.ElapsedTicks}");

            //ThreadPool.GetMaxThreads(out int workerThreads, out int completionworkerThreads);

            //Console.WriteLine(workerThreads);
            //Console.WriteLine(completionworkerThreads);
        }

        static void Process(object callback)
        {
         
        }

        static void ProcessWithTheadMethod()
        {
            for (int i = 0; i <= 2; i++)
            {
                var obj = new Thread(Process);
                obj.Start();
            }
        }

        static void ProcessWithTheadPoolMethod()
        {
            for (int i = 0; i <= 2; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process));

                
            }
        }
    }
}
 