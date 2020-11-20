using System;

namespace InheritanceSample
{
    public class RpgHero : Human
    {
        public string Class { get; set; }

        

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} {LastName} - {Class}");
        }

        public RpgHero(string fn, string ln, string clas) 
            : base(fn, ln)
        {
            Class = clas;
        }
    }

}