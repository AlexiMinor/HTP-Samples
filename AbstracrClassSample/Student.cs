using System;

namespace AbstractClassSample
{
    public class Student : Human
    {
    

        public string ClassInfo { get; set; }

        public Student(string name, int height, string classInfo) 
            : base(name, height)
        {
            ClassInfo = classInfo;
        }

        public void GoToSchool()
        {
            Console.WriteLine("I'm going to school");
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {ClassInfo} {Height}");
        }
    }
}