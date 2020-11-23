namespace HomeWorkOOPSample.Models
{
    public class NonTaxiCar : Car
    {
        public void GetTaxiLicense()
        {

        }

        public NonTaxiCar(string manufacturer, string model, decimal price, float fuelConsumption, int maxSpeed) : base(manufacturer, model, price, fuelConsumption, maxSpeed)
        {
        }
    }
}