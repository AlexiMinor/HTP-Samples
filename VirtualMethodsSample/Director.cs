using System;

namespace VirtualMethodsSample
{
    public class Director : Human
    {
        public string Organisation { get; set; }
        public Director(string name, int height, string org) 
            : base(name, height)
        {
            Organisation = org;
        }

        public sealed override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{Name} {Organisation}");

        }
    }
}