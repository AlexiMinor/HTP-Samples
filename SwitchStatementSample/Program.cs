using System;

namespace SwitchStatementSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Y on N");
            var selection = Console.ReadLine();
            int x = Convert.ToInt32(Console.ReadLine());


            switch (x)
            {
                case 1:
                    Console.WriteLine($"You enter {x}");
                    break;
                case 2:
                    Console.WriteLine($"You enter {x}");
                    break;
                case 3:
                    Console.WriteLine($"You enter {x}");
                    break;
                case 4:
                    Console.WriteLine($"You enter {x}");
                    break;
                case 5:
                    goto case 15;
                case 6:
                    Console.WriteLine($"You enter {x}");
                    break;
                case 7:
                    Console.WriteLine($"You enter {x}");
                    break;
                case 8:
                    goto case 1;
                case 15:
                    goto case 4;
                default:
                    Console.WriteLine($"You enter {x}");
                    break;

            }


            switch (selection)
            {
                case "Y":
                    Console.WriteLine("You pressed y");
                    break;
                case "y":
                    goto case "Y";
                case "N":
                    Console.WriteLine("You pressed n");
                    break;
                default:
                    Console.WriteLine("You pressed unknown symbol");
                    break;

            }

        }
    }
}
