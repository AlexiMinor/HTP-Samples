using System;

namespace VirtualMethodsSample
{
    public class Professor : Teacher
    {
        public Professor(string name, int height, string prof) 
            : base(name, height, prof)
        {
        }

        public new void WorkInSchool()
        {
            Console.WriteLine("123");
        }
    }
}