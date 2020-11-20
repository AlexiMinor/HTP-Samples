using System;

namespace StructureSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var parStr = new ParentStructure();
            parStr.Id = Guid.NewGuid();

            var sUser1 = new UserInfo("Tom", 26);
            Console.WriteLine("User 1(structure):");
            sUser1.PrintUserInfo();

            var sUser2 = new UserInfo("Bob", 30);
            Console.WriteLine("User 2(structure):");
            sUser2.PrintUserInfo();

            var clUser1 = new User("Tom", 26);
            Console.WriteLine("User 1(class):");
            clUser1.PrintUser();

            var clUser2 = new User("Bob", 30);
            Console.WriteLine("User 2(class):");
            clUser2.PrintUser();

            Console.WriteLine("______________________________________");

            sUser1 = sUser2;
            sUser2.Name = "Alice";
            sUser2.Age = 22;

            Console.WriteLine("User 1(structure):");
            sUser1.PrintUserInfo();
            Console.WriteLine("User 2(structure):");
            sUser2.PrintUserInfo();

            Console.WriteLine("______________________________________");

            clUser1 = clUser2;
            clUser2.Name = "Alice";
            clUser2.Age = 22;

            Console.WriteLine("User 1(class):");
            clUser1.PrintUser();
            Console.WriteLine("User 2(class):");
            clUser2.PrintUser();
        }
    }
}
