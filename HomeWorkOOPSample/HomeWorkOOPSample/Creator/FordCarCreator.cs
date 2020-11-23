using System;
using HomeWorkOOPSample.Models;

namespace HomeWorkOOPSample.Creator
{
    public class FordCarCreator : TaxiCreator
    {
        private const string MANUFACTURER = "Ford";

        public override BaseTaxiCar Create(string model)
        {
            switch (model)
            {
                case "Focus":
                    return CreateFocus();

                case "Transit":
                    return CreateTransit();

                default:
                    Console.WriteLine("Smth went wrong");
                    return null;
            }
        }

        private static TaxiCar CreateFocus()
        {
            return new TaxiCar(MANUFACTURER, "Focus", 15000, 5, 180, 4, 1);
        }

        private static CargoCar CreateTransit()
        {
            return new CargoCar(MANUFACTURER, "Transit", 100000, 10, 300, 15);
        }



    }
}