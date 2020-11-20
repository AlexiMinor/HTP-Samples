using System;

namespace StructureSample
{
    public class User
    {
        public string Name;

        public byte Age;

        public User(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public void PrintUser()
        {
            Console.WriteLine($"{Name}, Age: {Age}");
        }
    }
}