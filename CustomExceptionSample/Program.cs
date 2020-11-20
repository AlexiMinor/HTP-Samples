using System;

namespace CustomExceptionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var personWhoSmoke = new PersonWhoSmoke() { Age = 17, Name = "Bob" };
            }
            catch (PersonAgeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Incorrect age value: {ex.Value}");
            }
        }
    }
}
