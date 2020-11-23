using System;

namespace HomeWorkOOPSample.Models
{
    public class ComfortTaxiCar : TaxiCar
    {
        private bool _isMusicWasEnabledInLastRide;
        
        public float MusicCoefficient { get; set; }

        public ComfortTaxiCar(string manufacturer, string model, decimal price, 
            float fuelConsumption, 
            int maxSpeed, 
            int passengerCapacity, 
            float coefficient, float musicCoefficient) 
            : base(manufacturer, model, price, fuelConsumption, maxSpeed, passengerCapacity, coefficient)
        {
            MusicCoefficient = musicCoefficient;
        }

        public void PlayMusic()
        {
            _isMusicWasEnabledInLastRide = true;

            Console.WriteLine("Play music for client");
        }

        public override decimal CalculateRidePrice(Ride ride)
        {
            var result = ride.Distance * Coefficient;

            if (_isMusicWasEnabledInLastRide)
            {
                result *= MusicCoefficient;
            }

            _isMusicWasEnabledInLastRide = false;
            return (decimal)result;
        }

       
    }
}