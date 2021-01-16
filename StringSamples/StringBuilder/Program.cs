using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            var testString = "Hello World!";
            Console.WriteLine(testString.Length);
            var value = Convert.ToInt32(Console.ReadLine());
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < value; i++)
            {
                testString += "Hello World";
                Console.WriteLine($"lenght - {testString.Length}");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //var sb = new System.Text.StringBuilder(250);
            var testStringBuilder = new System.Text.StringBuilder("Hello World!");
            
            value = Convert.ToInt32(Console.ReadLine());
            sw.Reset();
            sw.Restart();
            for (int i = 0; i < value; i++)
            {
                testStringBuilder.Append("Hello World");
                Console.WriteLine($"lenght - {testStringBuilder.Length}");
                Console.WriteLine($"capacity - {testStringBuilder.Capacity}");

            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
    }
}
