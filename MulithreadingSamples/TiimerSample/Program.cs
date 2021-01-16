using System;
using System.Threading;

namespace TiimerSample
{
    class Program
    {
        private static int number = 1;
        static void Main(string[] args)
        {

            var callback = new TimerCallback(PrintTableOfMultiplication);

            var timer  = new Timer(callback, number, 0, 500);

            Console.ReadLine();
        }

        static void PrintTableOfMultiplication(object obj)
        {
            var x = (int) obj;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(x*i);
            }

            
        }
    }
}
