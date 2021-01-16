using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Linq;

namespace ParallelSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(() => {Console.WriteLine("hello world");}, 
            //                            DisplayData,
            //                            ()=> Do(1000));

            var forResult = Parallel.For(1, 100, (param, pls) =>
            {
                long result = param * param;
                if (result == 25)
                {
                    pls.Stop();
                }
                Console.WriteLine(result);
            });
            Console.WriteLine($"Element with pow 2 equals 25 is {forResult.LowestBreakIteration}");

            forResult = Parallel.For(1,100, (param, pls) =>
            {
                long result = param * param;
                if (result == 25)
                {
                    pls.Break();
                }
                Console.WriteLine(result);
            });

          
            Console.WriteLine($"Element with pow 2 equals 25 is {forResult.LowestBreakIteration}");

            Console.WriteLine("____________________________________");
            ConcurrentBag<double> bag = new ConcurrentBag<double>();
            var listOfData = new List<int>() { 1, 13, 15, 12, 11, 100, 1414, 123123, 123123123, 12312312 };
            var result = Parallel.ForEach(listOfData, (param) =>
            {
                double result = param * param;
                bag.Add(result);
                Console.WriteLine(result);
            });


            Console.Read();
        }

        static void DisplayData()
        {
            Console.WriteLine(Task.CurrentId);
        }

        static void Do(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(Task.CurrentId);
            }
        }
    }
}
