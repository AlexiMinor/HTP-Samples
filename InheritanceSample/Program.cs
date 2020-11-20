using System;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Bob", "Black");
            human.PrintInfo();

            human = new RpgHero("Bilbo", "Baggins", "Traveler");
            human.PrintInfo();




            var bilbo = new RpgHero("Bilbo", "Baggins", "Traveler");
            //bilbo.PrintInfo();
            bilbo.DisplayInfo();

            var human2 = new Human("1", "2");



            //if (human2 is RpgHero)
            //{
            var x = 0;
                //}

                //if (bilbo is Human)
                //{
                //    Console.WriteLine("Bilbo is human");
                //}

                //if (bilbo is RpgHero)
                //{
                //    Console.WriteLine("Bilbo is RpgHero");
                //}





        }
    }
}
