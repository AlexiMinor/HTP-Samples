using System;

namespace CatchAdditionalSample
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                var array = new int[4];
                Console.WriteLine(array[5]);
                var ex = new Exception();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
