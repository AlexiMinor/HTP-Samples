using System;
using DelegatesAndEventsSample.Delegates;

namespace DelegatesAndEventsSample
{
    public class Calculator
    {
        public delegate double GravitationConst();

        public static double CalculateGravityPower(int mass, GravitationConst del)
        {
            var gravConst = del();
            return mass * gravConst;
        }

        private static double Add(int x, int y)
        {
            return x + y;
        }

        private static double Multiply(int x, int y)
        {
            return x * y;
        }

        private static double Subtracts(int x, int y)
        {
            return x - y;
        }

        private static double Division(int x, int y)
        {
            return (double)x / y;
        }

        public static Operation Caluclate(string operation)
        {
            switch (operation)
            {
                case "+":
                    return new Operation(Add);
                case "-":
                    return Subtracts;
                case "*":
                    return Multiply;
                case "/":
                    return Division;
                default:
                    return null;
            }

            //Console.WriteLine(op(x, y));
        }
    }
}