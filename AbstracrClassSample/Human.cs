using System;

namespace AbstractClassSample
{
    public abstract class Human
    {
        public string Name { get; set; }
        public int Height { get; set; }

        protected Human(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public abstract void PrintInfo();
    }
}