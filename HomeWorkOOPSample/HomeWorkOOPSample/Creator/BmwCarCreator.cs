using System;
using HomeWorkOOPSample.Models;

namespace HomeWorkOOPSample.Creator
{
    public class BmwCarCreator : TaxiCreator
    {
        private const string MANUFACTURER = "Bmw";

        public override BaseTaxiCar Create(string model)
        {
            switch (model)
            {
                case "3er":
                    return Create3er();

                case "7er":
                    return Create7er();

                default:
                    Console.WriteLine("Smth went wrong");
                    return null;
            }
        }

        private static ComfortTaxiCar Create3er()
        {
            return new ComfortTaxiCar(MANUFACTURER, "3er", 35000, 8, 240, 4, 2, 1.5f);
        }

        private static LuxuryTaxiCar Create7er()
        {
            return new LuxuryTaxiCar(MANUFACTURER, "7er", 100000, 10, 300, 4, 3, 15);
        }
    }
}