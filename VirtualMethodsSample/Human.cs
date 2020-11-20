using System;

namespace VirtualMethodsSample
{
    public class Human
    {
        public string Name { get; set; }
        public int Height { get; set; }

        protected Human(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name} {Height}");
        }
    }
}