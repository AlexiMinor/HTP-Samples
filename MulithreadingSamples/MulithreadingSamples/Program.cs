using System;
using System.Threading;

namespace MulithreadingSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var thread = Thread.CurrentThread;
            var context = thread.ExecutionContext;

            Console.WriteLine($"Thread name: {thread.Name}");
            thread.Name = "Main Method";
            Console.WriteLine($"Thread name: {thread.Name}");

            Console.WriteLine($"Thread is Alive: {thread.IsAlive}");
            Console.WriteLine($"Thread is Background: {thread.IsBackground}");
            Console.WriteLine($"Thread priority: {thread.Priority}");
            Console.WriteLine($"Thread state: {thread.ThreadState}");
            Console.WriteLine($"App domain: {Thread.GetDomainID()}");
            Console.WriteLine($"App domain: {Thread.GetDomain().FriendlyName}");

            Thread.Sleep(10000);

            thread.Join();
            thread.Start();
         
        }
    }
}
