using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancelationTokenSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            var task = new Task(() => Facrotial(15, cancellationToken));
            task.Start();

            Console.WriteLine("Enter cancel for cancel operation");
            var input = Console.ReadLine();

            if (input != null && input.ToLowerInvariant() == "cancel")
            {
                cancellationTokenSource.Cancel();
            }

            Console.ReadLine();

        }

        static int GetValue()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        
        [Obsolete]
        static void Facrotial(int x, CancellationToken token)
        {
            var result = 1;
            for (var i = 1; i < 25; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Operation was canceled");
                    Thread.Sleep(1000);
                    return;
                }

                result *= i;
                Console.WriteLine($"{i}! = {result}");
                Thread.Sleep(5000);
            }
        }
    }
}
