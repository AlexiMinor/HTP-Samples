using System;

namespace PartialClassSample
{
    public partial class Cat
    {
        public string Name { get; set; }
        public void Move()
        {
            Walk();
            Console.WriteLine($"{Name}'s doing Tygydyg");
        }

        partial void DoSmth();
        partial void Walk();
    }
}