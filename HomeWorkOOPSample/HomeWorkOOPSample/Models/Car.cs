namespace HomeWorkOOPSample.Models
{
    public abstract class Car 
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public float FuelConsumption { get; set; }
        public int MaxSpeed { get; set; }

        protected Car(string manufacturer, string model, decimal price, float fuelConsumption, int maxSpeed)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            FuelConsumption = fuelConsumption;
            MaxSpeed = maxSpeed;
        }
    }
}