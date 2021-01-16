using System;
using DelegatesAndEventsSample.Delegates;

namespace DelegatesAndEventsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Greetings.GreetSomeone();

            Calculator.CalculateGravityPower(100, new Calculator.GravitationConst(CalculateGravitationConst));

            //Console.WriteLine("Enter x:");
            //int.TryParse(Console.ReadLine(), out int x);
            //Console.WriteLine("Enter y:");
            //int.TryParse(Console.ReadLine(), out int y);

            //Console.WriteLine("Enter operation type:");
            //var op = Console.ReadLine();

            //Operation operation = Calculator.Caluclate(op);

            //Console.WriteLine(operation(x,y));


        }

        static double CalculateGravitationConst()
        {
            return 9.8;
        }
    }
}
