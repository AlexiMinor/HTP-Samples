using System;
using System.Collections.Generic;
using System.Threading;

namespace MonitorSample
{
    class Program
    {
        static int number = 0;
        static readonly object locker = new object();

        static void Process(object callback)
        {
            var isLock = false;
            try
            {
                Monitor.Enter(locker, ref isLock);
                number = 1;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(number);
                    number++;
                }
            }
            finally
            {
                if (isLock) 
                {
                    Monitor.Exit(locker);
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }

            Thread.Sleep(2000);
        }


    }
}