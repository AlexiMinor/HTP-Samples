using System;

namespace AbstractClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Bob", 150, "10A");
            var teacher = new Teacher("Dan", 200, "Geography");


            student.PrintInfo();
            teacher.PrintInfo();

            Console.WriteLine("Hello World!");
        }
    }
}
