using System;

namespace AdditionalDelegatesSample
{
    class Program
    {
        delegate void PrintEmployeeInfo(Employee employee);

        delegate Human HumanFactory(string name, string lastName);

        static void Main(string[] args)
        {
            HumanFactory hf;
            hf = BuildEmployee;
            hf("Bill", "Gates");

            PrintEmployeeInfo pei;

            pei = PrintHumanInfo;


        }

        private static void PrintHumanInfo(Human human)
        {
            Console.WriteLine(human.FirstName);
        }

        private static Employee BuildEmployee(string fn, string ln) =>
            new Employee
            {
                FirstName = fn, 
                LastName = ln, 
                Company = "Microsoft"
            };
    }
}
