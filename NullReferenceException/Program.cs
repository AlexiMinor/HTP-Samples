using System;

namespace NullReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                var B = new B();

                int? parameter = B.Obj.Value;

                Console.WriteLine(parameter);
            //}
            //catch (System.NullReferenceException e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            Console.WriteLine("a");
        }
    }

    class A
    {
        public int Value { get; set; }
    }

    class B
    {
        public A Obj { get; set; }
        public string S { get; set; }
    }
}
