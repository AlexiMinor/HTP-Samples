using System;
using System.Collections.Generic;
using System.Threading;

namespace LockSample
{
    class Program
    {
        static int number = 0;
        static readonly object locker = new object();
        static readonly object locker1 = new object();
        static readonly object locker2 = new object();
        static readonly object locker3 = new object();
        static readonly object locker4 = new object();

        static List<int> list = new List<int>();

        static void FillList(object callback)
        {
            lock (locker)
            {
                for (int i = 0; i < 1000; i++)
                {
                    list.Add(i);
                }
            }
        }

        static void ReadList(object callback)
        {
            foreach (var i1 in list)
            {
                Console.WriteLine(i1);
            }
        }

        static void Process(object callback)
        {
            number = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        static void Main(string[] args)
        {
            var obj = new Thread(FillList);
            obj.Start();
            var obj2 = new Thread(FillList);
            obj2.Start();
            var obj1 = new Thread(ReadList);
            obj1.Start();
        }


    }
}
