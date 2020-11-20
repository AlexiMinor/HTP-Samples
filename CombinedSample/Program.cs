using System;

namespace CombinedSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = new Country() { Area = 15.5};
            var country2 = new Country() { Area = 15.5};

            var tourist = new Tourist()
            {
                X = 10, 
                Name = "Bob", 
                HomeCountry = country
            };
            var tourist2 = new Tourist()
            {
                X = 15, 
                Name = "Alice", 
                HomeCountry = country
            };
        }
    }
}
