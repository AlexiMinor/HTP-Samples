using System;

namespace LambdaSample
{
    class Program
    {
        delegate double Operation(int x, out int y);

        delegate long SquareOperation(int x);

        delegate string HelloWorld();

        delegate void PrintMessage(string message);

        delegate bool IsMoreOrEqual(int x, int y);

        static void Main(string[] args)
        {
            Operation operation = (int x, out int i) => i =  x + x;

            SquareOperation sq = i => i * i;

            HelloWorld hw = () => "Hello World";


            hw();
            sq(5);
            operation(2, out int y);

            Console.WriteLine(y);

            Substract(10, y, (x, y) => x >= y);
        }

        private static void ConsoleWL(string par, PrintMessage message)
        {
            message(par);
        }

        private static ulong Substract(int x, int y, IsMoreOrEqual func)
        {
            if (func(x,y))
            {
                return (ulong)(x - y);
            }

            return 0;
        }

        private static double Sum(int x, out int y)
        {
            return y = x + x;
        }
    }
}
