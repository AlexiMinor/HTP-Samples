using System;

namespace ExceptionWithThrowSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int.TryParse(Console.ReadLine(), out var y);

                //if (y == 0)
                //{
                //    throw new DivideByZeroException("Attempt to divide my zero");
                //}
                //var result = x / y;

                var result = Calculate(x, y);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                
            }
          
        }

        static double Calculate(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine("Handled exception");
                throw new Exception("divide by zero", e);
            }
        }
    }
}
