using System;

namespace AbstractClassSample
{
    public class Teacher : Human
    {
        public string Proficiency { get; set; }

        public Teacher(string name, int height, string proficiency)
            : base(name, height)
        {
            Proficiency = proficiency;
        }

        public void WorkInSchool()
        {
            Console.WriteLine("I work to school");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Proficiency}");

        }
    }
   
}