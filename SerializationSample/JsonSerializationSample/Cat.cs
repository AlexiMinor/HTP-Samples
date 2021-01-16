using System;

namespace JsonSerializationSample
{
    [Serializable]
    public class Cat 
    {
        private readonly bool _isLovingWater;
   
        public string Name { get; set; }

        public char Symbol { get; set; }

        public int Age { get; set; }

        public int[] Lives { get; set; }

        public Color Color { get; set; }

        public void Do()
        {
            Console.WriteLine("Do method");
        }
    }

    public enum Color
    {
        Grey,
        Brown, 
        Black,
        White
    }
}