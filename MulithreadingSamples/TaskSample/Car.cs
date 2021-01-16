using System;

namespace TaskSample
{
    public class Car
    {
        public int MaxSpeed { get; set; }

        public void Accelerate()
        {
            for (int i = 0; i < MaxSpeed; i++)
            {
                Console.WriteLine($"Current Speed {i}");
            }
        }
    }
}