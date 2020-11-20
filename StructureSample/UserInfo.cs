using System;

namespace StructureSample
{
    public struct UserInfo : IDoable
    {
        public string Name;

        public byte Age;

        public UserInfo(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"{Name}, Age: {Age}");
        }

        public void Do()
        {
            Console.WriteLine("Do");
        }
    }
}