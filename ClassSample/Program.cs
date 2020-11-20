using System;
using System.Collections.Generic;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human bob = new Human("bob","Bob", "Grey");

            bob.PrintInfo();


            bob.A = ReadNumberFromConsole();

            var human = new Human("bob", "Bob", "Grey")
            {
                A = 14,
                LastName = "lastName",
                FirstName = "firstname"

            };
            human.PrintInfo();

            var cat = new Cat()
            {
                Name = "Tom", 
                Color = "Gray", 
                Age = 80,
            };
          
        }

        public static double ReadNumberFromConsole()
        {
            Console.WriteLine("Print number");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
