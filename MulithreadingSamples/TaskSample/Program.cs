using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            var t = new Task(()=>DisplayInformation(out x));
            t.Start();

            Console.WriteLine(x);

            var factTask = new Task<long>(() => CalculateFactorial(15));
            factTask.Start();
            var factorial = factTask.Result;

            var car = new Car { MaxSpeed = 200 };
            var accTask = new Task(car.Accelerate);
            accTask.Start();

            Console.WriteLine("Method Main finish work");

            TaskCollection();

            //Console.ReadLine();

            InnerTask();

            ContinueWithTask();
        }

        static void DisplayInformation(out int x)
        {
            Console.WriteLine("Method DisplayInformation start work");
            Console.WriteLine("Method DisplayInformation finish work");

            x = 15;
        }

        static long CalculateFactorial(int x)
        {
            var factorial = 1;

            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static void TaskCollection()
        {
            var taskList = new List<Task<string>>()
            {
                new Task<string>(() => "Hello"),
                new Task<string>(() => "Amazing"),
                new Task<string>(() => "World"),
            };

            foreach (var task in taskList)
            { 
                task.Start();
            }

            var taskList2 = new List<Task<int>>();

            for (int i = 0; i < 5; i++)
            {
                taskList2.Add(Task.Factory.StartNew(()=>i));

            }

            var taskList3 = new List<Task<int>>();

            for (int i = 0; i < 5; i++)
            {
                taskList2.Add(Task.Run(() => i));
            }
        }

        static void InnerTask()
        {
            var outerTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello from outerTask");

                var innerTask = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Hello from innerTask");
                    Thread.Sleep(2000);
                    Console.WriteLine("Buy from innerTask");

                }, TaskCreationOptions.AttachedToParent);
            });

            outerTask.Wait();
        static void InnerTask()
        {
            var outerTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello from outerTask");

                var innerTask = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Hello from innerTask");
                    Thread.Sleep(2000);
                    Console.WriteLine("Buy from innerTask");

                }, TaskCreationOptions.AttachedToParent);
            });

            outerTask.Wait();
        }
        }

        static void ContinueWithTask()
        {
            var t1 = new Task(() =>
            {
                Console.WriteLine($"{Task.CurrentId}");
            });

         
            var t2 = t1.ContinueWith(DisplayInfoAboutTasks);
            t1.Start();
            t2.Wait();
        }

        static void DisplayInfoAboutTasks(Task task)
        {
            Console.WriteLine($"Current task id - {Task.CurrentId}");
            Console.WriteLine($"Previous task id - {task.Id}");
            Thread.Sleep(1000);
        }

        static void Calculate(Task<int> task)
        {
            var x = task.Result;
        }
    }
}
