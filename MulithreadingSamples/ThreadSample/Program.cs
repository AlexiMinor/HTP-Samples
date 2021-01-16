using System;
using System.Threading;

namespace ThreadSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var customThread = new Thread(new ThreadStart(Do));
            //customThread.Start();

            //int distance = 5000;

            //var runThread = new Thread(new ParameterizedThreadStart(Run));
            //runThread.Start(distance);

            var thread = Thread.CurrentThread;
            thread.Name = "Main method thread";
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{thread.Name} - {i}");
            }



            //ThreadJoinSampleClass.RunSample();
            ThreadPool.QueueUserWorkItem(Run, 15);
            
            Console.WriteLine("Main thread does some work, then sleep ");

            Console.WriteLine(ThreadPool.ThreadCount);
            Thread.Sleep(10000);
            Console.WriteLine("Main thread exits");

        }

        public static void Do()
        {
            var thread = Thread.CurrentThread;
            thread.Name = "Do method thread";
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{thread.Name} - {i}");
            }
        }


        public static void Run(object distance)
        {
            var d = (int) distance;
            var thread = Thread.CurrentThread;

            thread.Name = "Run method thread";
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine($"{thread.Name} - run {i} meters");
            }
        }
    }
}
