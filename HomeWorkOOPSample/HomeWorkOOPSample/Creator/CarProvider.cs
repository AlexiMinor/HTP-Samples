using System;
using HomeWorkOOPSample.Models;

namespace HomeWorkOOPSample.Creator
{
    public  class CarProvider
    {
        private readonly BmwCarCreator _bmwCarCreator;
        private readonly FordCarCreator _fordCarCreator;

        public CarProvider(BmwCarCreator bmwCarCreator, 
            FordCarCreator fordCarCreator)
        {
            _bmwCarCreator = bmwCarCreator;
            _fordCarCreator = fordCarCreator;
        }

        public  BaseTaxiCar GetCarByManufacturerAndModel(string manufacturer, string model)
        {
            switch (manufacturer)
            {
                case "Ford":
                    return _fordCarCreator.Create(model);
                case "Bmw":
                    return _bmwCarCreator.Create(model);
                default:
                    Console.WriteLine("Smth went wrong");
                    return null;

            }
        }
    }
}