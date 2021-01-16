using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgrammingSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var task = DoAsync();

                int.TryParse(Console.ReadLine(), out int i);
                Console.WriteLine(i * i);

                task.Wait();

                var task1 = CalculateAsync(15);

                var result1 = await CalculateAsync(17);

                Console.ReadLine();

                CancellationTokenSource source = new CancellationTokenSource();
                var x = await TryExecute(15, source.Token);
                Console.WriteLine(x);
                source.Cancel();
                var z = await TryExecute(15, source.Token);
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        static void Do()
        {
            for (int i = 0; i < 10000; i++)
            {
            }

            Thread.Sleep(1500);
        }

        static async void CalculateSynchronously()//technically async but sync in the fact
        {
            await Task.Run(() => Calculate());
            await Task.Run(() => Calculate());
            await Task.Run(() => Calculate());
            await Task.Run(() => Calculate());
            await Task.Run(() => Calculate());
        }

        static async Task DoAsync()
        {
           Console.WriteLine("async method started");
           await Task.Run(() => Do());
           Console.WriteLine("async method finished");
        }

        static async Task CalculateValueAsync()
        {
            var result = await Task.Run(Calculate);
        }

        static async Task<int> CalculateAsync(int param)
        {
            Console.WriteLine("async calc method started");

            var value = await Task.Run(() =>
            {
                Thread.Sleep(500);
                return param;
            });

            
            Console.WriteLine("async calc method finished");
            return value;
        static async Task<int> CalculateAsync(int param)
        {
            Console.WriteLine("async calc method started");

            var value = await Task.Run(() =>
            {
                Thread.Sleep(500);
                return param;
            });

            
            Console.WriteLine("async calc method finished");
            return value;
        }
        }

        static async Task<DateTime> GetDate()
        {
           return await Task.Run(() => DateTime.Now);
        }

        static async Task<int> Calculate() => 15;

        static async Task<int> TryExecute(int par, CancellationToken token)
        {
            try
            {
                for (int i = 0; i < 100000000; i++)
                {
                    if (i>10000 && token.IsCancellationRequested)
                    {
                        return 0;
                    }
                }
                if (par<0)
                {
                    throw new ArgumentException();
                }

                return par;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
   
    }
}
