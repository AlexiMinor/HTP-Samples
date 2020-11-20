using System;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = StoreOrder.Discount;

            Console.WriteLine("We have dicsount: ");

            

            StoreOrder.PrintDiscount();
            var precalculatedPrice = StoreOrder.Precalculate(15000m);

            Console.WriteLine(precalculatedPrice);


            var order1 = new StoreOrder(150.15m);
            Console.WriteLine($"Total order1 sum = {order1.TotalSum}");

            var order2 = new StoreOrder(50.66m);
            Console.WriteLine($"Total order2 sum = {order2.TotalSum}");

            StoreOrder.Discount = 15;

            var order3 = new StoreOrder(130.1m);
            Console.WriteLine($"Total order3 sum = {order3.TotalSum}");

            var order4 = new StoreOrder(1504.15m);
            Console.WriteLine($"Total order4 sum = {order4.TotalSum}");

        }
    }
}
