using System;

namespace HomeWorkOOPSample.Models
{
    public abstract class BaseTaxiCar : Car, IPriceRideable
    {
        protected BaseTaxiCar(string manufacturer, string model, decimal price, float fuelConsumption, int maxSpeed) : base(manufacturer, model, price, fuelConsumption, maxSpeed)
        {
        }

        public abstract decimal CalculateRidePrice(Ride ride);

        public override string ToString()
        {
            return
                $"{Manufacturer}-{Model}: Price: {Price} | MaxSpeed: {MaxSpeed} | Fuel Consumption: {FuelConsumption}";
        }
    }
}