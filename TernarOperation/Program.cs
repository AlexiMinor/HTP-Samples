using System;

namespace TernarOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 15;

            Console.WriteLine("Press '+' or '-'");
            var selection = Console.ReadLine();

            double z = selection == "+" ? x + y : x / y;

            Console.WriteLine(z);

            
        }
    }
}
