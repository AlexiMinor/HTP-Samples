using System;

namespace PartialClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat() { Name = "Tom"};
            cat.Move();
            cat.Eat();
        }
    }
}
