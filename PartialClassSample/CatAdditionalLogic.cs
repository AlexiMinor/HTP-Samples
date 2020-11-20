using System;

namespace PartialClassSample
{
    public partial class Cat
    {
        public void Eat()
        {
            Walk();
            Console.WriteLine($"{Name} Drink milk");
        }

        partial void DoSmth()
        {
            Walk();

            Console.WriteLine("Do smth");
        }


    }
}