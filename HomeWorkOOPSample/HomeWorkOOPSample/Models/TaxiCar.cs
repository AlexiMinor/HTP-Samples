namespace HomeWorkOOPSample.Models
{
    public class TaxiCar : BaseTaxiCar
    {
        public int PassengerCapacity { get; set; }

        public float Coefficient { get; set; }

        public TaxiCar(string manufacturer, string model, decimal price, 
            float fuelConsumption, 
            int maxSpeed, 
            int passengerCapacity, 
            float coefficient) 
            : base(manufacturer, model, price, fuelConsumption, maxSpeed)
        {
            PassengerCapacity = passengerCapacity;
            Coefficient = coefficient;
        }

        public override decimal CalculateRidePrice(Ride ride)
        {
            return (decimal) (ride.Distance * Coefficient);
        }
    }
}