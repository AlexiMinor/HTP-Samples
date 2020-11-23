namespace HomeWorkOOPSample.Models
{
    public class CargoCar : BaseTaxiCar
    {
        public int MaxCargoCapacity { get; set; }

        public override decimal CalculateRidePrice(Ride ride)
        {
            return (decimal)(ride.Distance * ride.Duration.TotalHours * (ride.CargoCapacity / MaxCargoCapacity));
        }

        public CargoCar(string manufacturer, string model, decimal price, float fuelConsumption, int maxSpeed, int maxCargoCapacity) 
            : base(manufacturer, model, price, fuelConsumption, maxSpeed)
        {
            MaxCargoCapacity = maxCargoCapacity;
        }
    }

    //public class CargoCar2 : CargoCar, IPriceRideable
    //{
    //    public new decimal CalculateRidePrice(Ride ride)
    //    {
    //        return 1;

    //    }

    //    decimal IPriceRideable.CalculateRidePrice(Ride ride)
    //    {
    //        return 0;
    //    }

    //}
}