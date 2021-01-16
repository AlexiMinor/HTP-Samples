using System;
using System.Threading;

namespace AutoResetEventSample
{
    class Program
    {
        static int number = 0;
        static AutoResetEvent waitHandler  = new AutoResetEvent(true);
        static AutoResetEvent waitHandler2  = new AutoResetEvent(false);
        
        static void Process(object callback)
        {
            //AutoResetEvent.WaitAny();
            //waitHandler.WaitOne();
            WaitHandle.WaitAll(new WaitHandle[] { waitHandler, waitHandler2 });

            number = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number);
                number++;
            }

            waitHandler.Set();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                var thread = new Thread(Process);
                thread.Start();
            }

            Thread.Sleep(2000);
            waitHandler2.Set();

        }


    }
}
