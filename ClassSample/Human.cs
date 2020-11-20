using System;

namespace ClassSample
{
    public class Human
    {
        public const string TEST_STRING = "Test string";

        private int _weight;
        private int _height;

        public double A;

        private readonly string _eyeColor;

        public string LastName;

        public string FirstName { get; set; }

        public Human()
        {
        }

        public Human(string eyeColor)
        {
            _eyeColor = eyeColor;
        }

        public Human(string FirstName, string lastName, string eyeColor)
        {
            this.FirstName = FirstName;
            LastName = lastName;
            _eyeColor = eyeColor;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {_eyeColor}");
        }
    }
}