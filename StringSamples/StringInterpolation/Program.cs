using System;
using System.Globalization;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cat = new Cat() { Name = "Vasily", Color = "Black" };
            var outputString = string.Format("Cat with Name: {0} have color {1}", cat.Name, cat.Color);
            Console.WriteLine(outputString);
            Console.WriteLine("Cat with Name: {0} have color {1}", cat.Name, cat.Color);
            Console.WriteLine($"Cat with Name: {cat.Name} have color {cat.Color}");

            var doubleValue = 412312315.123456;

            Console.WriteLine(doubleValue.ToString("###########.00000"));
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
