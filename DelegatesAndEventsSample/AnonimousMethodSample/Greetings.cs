using System;

namespace AnonimousMethodSample
{
    public class Greetings
    {
        delegate void Greet();
        delegate void Greet2(string message);



        public static void GreetSomeone()
        {
            Greet greet;
            Greet2 howAreU;
            Greet totalGreet;

            if (DateTime.Now.Hour <= 12)
            {
                greet = delegate
                {
                    Console.WriteLine("Good Morning");
                };
            }
            else
            {
                greet = GreetAtTheEvening;
            }

            howAreU = delegate(string message)
            {
                Console.WriteLine(message);
            };

            howAreU("Hello world");

        }

   
        private static void GreetAtTheEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}