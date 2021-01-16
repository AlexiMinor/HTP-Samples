using System;
using System.Threading;

namespace MutexSample
{
    class Program
    {
        static Mutex mutexObject = new Mutex();
        static int number = 0;

        static void Process(object callback)
        {
            mutexObject.WaitOne();
            number = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number);
                number++;
            }
            mutexObject.ReleaseMutex();
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

        }
    }
}
