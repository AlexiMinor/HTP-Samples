using System;

namespace InheritanceSample
{
    public class Human
    {
        private int _age;
        public string Name { get; set; }
        public string LastName { get; set; }

        public Human(string fn, string ln)
        {
            Name = fn;
            LastName = ln;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {LastName}");
        }


    }
}