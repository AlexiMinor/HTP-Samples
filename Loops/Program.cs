using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 10000.0;
            //continue //break
            for (var i = -10; i < 11; i++)
            {
                if (i == 0)
                    continue;

                var result = value / (i * i * i);
                if (result == 1250)
                {
                    Console.WriteLine(i);
                    break;
                }

                Console.WriteLine(result);
            }

            //int a = -1;
            //do
            //{
            //    Console.WriteLine(a);
            //    a--;
            //} while (a > 0);

            //a = -1;
            //while (a > 0)
            //{
            //    Console.WriteLine(a);
            //    a--;
            //}

            string s = "";
            while (!string.Equals(s, "exit", StringComparison.CurrentCulture))
            {
                Console.WriteLine("Press exit for exit");
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "exit":
                        break;
                    default:
                        Console.WriteLine($"Incorrect input");
                        break;
                }
            }
        }
    }
}
