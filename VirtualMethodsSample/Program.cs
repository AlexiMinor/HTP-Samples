using System;

namespace VirtualMethodsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Bob", 150, "10A");
            var teacher = new Teacher("Dan", 200, "Geography");
            var director = new Director("John", 180, "School");
            var prof = new Professor("Bill", 160, "University");


            Display(student);
            Display(teacher);
            Display(director);
            Display(prof);


            prof.WorkInSchool();
            teacher.WorkInSchool();

            Work(teacher);
            Work(prof);
        }

        static void Work(Teacher human)
        {
            human.WorkInSchool();
        }

        static void Display(Human human)
        {
            human.PrintInfo();

            //if (human is Student)
            //{
            //    Console.WriteLine(((Student) human).ClassInfo);
            //}

            //if (human is Teacher)
            //{
            //    Console.WriteLine(((Teacher)human).Proficiency);
            //}

            //if (human is Director)
            //{
            //    Console.WriteLine(((Director)human).Organisation);
            //}
        }
    }
}
