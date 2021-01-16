using System;

namespace SerializationSample
{
    [Serializable]
    public class Cat : Animal
    {
        [NonSerialized] 
        private readonly bool _isLovingWater;
   
        public string Name { get; set; }


        public override int Age
        {
            get;
            set;
        }

        public Color Color { get; set; }

        public Cat(string name, int age, Color color, bool isLovingWater)
        {
            Name = name;
            Age = age;
            Color = color;
            _isLovingWater = isLovingWater;
        }

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