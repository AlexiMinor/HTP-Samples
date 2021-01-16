using System;

namespace DelegatesAndEventsSample
{
    public class Greetings
    {
        public delegate void Greet();

        public static void GreetSomeone()
        {
            Greet greet;
            Greet howAreU;
            Greet totalGreet;

            if (DateTime.Now.Hour <= 12)
            {
                greet = GreetAtTheMorning;
            }
            else
            {
                greet = GreetAtTheEvening;
            }





            howAreU = PrintHowAreYou;


            totalGreet = greet + howAreU;


            totalGreet();
        }

        private static void GreetAtTheMorning()
        {
            Console.WriteLine("Good Morning");
        }

        private static void GreetAtTheEvening()
        {
            Console.WriteLine("Good Evening");
        }

        private static void PrintHowAreYou()
        {
            Console.WriteLine("How are u?");

        }
    }
}