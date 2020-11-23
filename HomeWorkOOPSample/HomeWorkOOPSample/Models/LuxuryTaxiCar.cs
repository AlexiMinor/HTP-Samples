using System;

namespace HomeWorkOOPSample.Models
{
    public class LuxuryTaxiCar : TaxiCar
    {
        private int _isWaterWasAksedAmount;

        public decimal WaterPrice { get; set; }

        public LuxuryTaxiCar(string manufacturer, string model, decimal price, 
            float fuelConsumption, 
            int maxSpeed, 
            int passengerCapacity, 
            float coefficient,
            decimal waterPrice)
            : base(manufacturer, model, price, fuelConsumption, maxSpeed, passengerCapacity, coefficient)
        {
            WaterPrice = waterPrice;
        }

        public void TakeWaterToClient()
        {
            _isWaterWasAksedAmount++;
            Console.WriteLine("Water was taken by client");
        }

        public override decimal CalculateRidePrice(Ride ride)
        {
            var result = (decimal)(ride.Distance * Coefficient);

            if (_isWaterWasAksedAmount != 0)
            {
                result += (WaterPrice * _isWaterWasAksedAmount);
            }

            _isWaterWasAksedAmount = 0;
            return result;
        }

      
    }
}