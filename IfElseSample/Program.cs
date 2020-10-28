using System;

namespace IfElseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 10;
            // && - and
            // ||- or
            if (number1 > number2)
            {
                Console.WriteLine($"Number {number1} more than {number2}");
            }

            else if(number2>number1)
            {
                Console.WriteLine($"Number {number1} less than {number2}");
            }

            else
            {
                Console.WriteLine($"Number {number1} equals {number2}");
            }
        }
    }
}
