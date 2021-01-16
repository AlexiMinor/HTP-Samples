using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace StringAndFilesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listA = new List<A>()
            {
                new A()
                {
                    Id = Guid.NewGuid(),
                    Value = "10",
                    BObjects = new List<B>()
                    {
                        new B() {Name = "A", LastName = "B"},
                        new B() {Name = "B", LastName = "B"},
                        new B() {Name = "C", LastName = "A"},
                        new B() {Name = "D", LastName = "C"},
                        new B() {Name = "E", LastName = "A"},
                    }

                },
                    new A()
                    {
                        Id = Guid.NewGuid(),
                        Value = "15",
                        BObjects = new List<B>()
                        {
                            new B() {Name = "A", LastName = "E"},
                            new B() {Name = "B", LastName = "B"},
                            new B() {Name = "C", LastName = "A"},
                            new B() {Name = "D", LastName = "C"},
                            new B() {Name = "E", LastName = "A"},
                        }
                    }

            };

            var bList = listA.SelectMany(a => a.BObjects).ToList(); //List<B>


            Console.WriteLine("Hello World!");
        }
    }

    class A
    {
        public Guid Id { get; set; }
        public string Value { get; set; }

        public List<B> BObjects { get; set; }
    }

    class B
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
