using HomeWorkOOPSample.Models;

namespace HomeWorkOOPSample.Creator
{
    public abstract class TaxiCreator
    {
        public abstract BaseTaxiCar Create(string model);
    }
}