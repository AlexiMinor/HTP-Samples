using System;

namespace SemaphoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var train = new Train(Guid.NewGuid());
            }
        }
    }
}
