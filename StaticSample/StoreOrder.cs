using System;

namespace StaticSample
{
    public class StoreOrder
    {
        public static int Discount = 20;
        public decimal TotalSum;
        public string OrderItem;
        public DateTime OrderDate;

        static StoreOrder()
        {
            Console.WriteLine("Static constructor was executed");
        }

        public StoreOrder(decimal sum)
        {
            Console.WriteLine("Nonstatic constructor was executed");
            TotalSum = sum - (sum / 100) * Discount;
        }

        public static decimal Precalculate(decimal sum)
        {
            return sum * (100 - Discount)/100;
        }

        public static void PrintDiscount()
        {
            Console.WriteLine(Discount);
        }

    }
}