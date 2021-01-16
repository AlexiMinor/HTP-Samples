namespace LinqSample
{
    public class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfProduction { get; set; }

        public Car(string model, string manufacturer, int yearOfProduction)
        {
            Model = model;
            Manufacturer = manufacturer;
            YearOfProduction = yearOfProduction;
        }
    }
}