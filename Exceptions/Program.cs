using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int result = x / y;

                DivideByZeroWithWhen();


                //MyClass obj = null;

                //Console.WriteLine(obj.S);

                //Console.WriteLine(Calc(x));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception was handled");
                Console.WriteLine(ex.Message);
            }
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("Exception was handled");
            //    Console.WriteLine("Null reference exception");
            //}
            //catch (StackOverflowException ex)
            //{
            //    Console.WriteLine("Exception was handled");
            //    Console.WriteLine("stack overflow exception");
            //}
            finally
            {
                Console.WriteLine("Final message before close");
            }
            

            Console.WriteLine("a");
            //ReadValuesFromConsole();
        }

        private static void DivideByZeroWithWhen()
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException ex) when (y ==0 && x ==0)
            {
                Console.WriteLine("Exception was handled");
                Console.WriteLine("You try to input 2 zeros");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception was handled");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.HelpLink);
            }
        }


        private static void ReadValuesFromConsole()
        {
            double x;
            double y;

            var userInput1 = Console.ReadLine();
            var userInput2 = Console.ReadLine();

            if (double.TryParse(userInput1, out x) && double.TryParse(userInput2, out y))
            {
                var result = x / y;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Exception was handled: you entered not a number");
            }
        }

        static int Calc(int x)
        {
            return Calc(x);
        }
    }

    class MyClass
    {
        public string S;
    }
}
