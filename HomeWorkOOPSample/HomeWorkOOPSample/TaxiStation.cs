using System;
using System.Collections.Generic;
using System.Linq;
using HomeWorkOOPSample.Models;

namespace HomeWorkOOPSample
{
    public class TaxiStation
    {
        public BaseTaxiCar[] Cars { get; private set; }

        public TaxiStation(BaseTaxiCar[] cars)
        {
            Cars = cars;
        }

        public void PrintCarsInfo()
        {
            PrintCars(Cars);
        }

        public decimal CalculateTotalPrice()
        {
            decimal result = 0;

            foreach (var baseTaxiCar in Cars)
            {
                result += baseTaxiCar.Price;
            }

            return result;
        }

        public void PrintCarsOrderedByFuelConsumption()
        {
            var orderedCars = Cars.OrderBy(car => car.FuelConsumption).ToArray();

            PrintCars(orderedCars);
        }

        public BaseTaxiCar[] FindCarBySpeed(int minSpeed)
        {
            int lenght = 0;
            foreach (var baseTaxiCar in Cars)
            {
                if (baseTaxiCar.MaxSpeed >= minSpeed)
                {
                    lenght++;
                }
            }

            var findedCars = new BaseTaxiCar[lenght];
            var flag = 0;
            foreach (var baseTaxiCar in Cars)
            {
                if (baseTaxiCar.MaxSpeed >= minSpeed)
                {
                    findedCars[flag] = baseTaxiCar;
                    flag++;
                }
            }

            return findedCars;
        }
        public BaseTaxiCar[] FindCarBySpeed(int minSpeed, int maxSpeed)
        {
            var findedCars = new List<BaseTaxiCar>();

            foreach (var baseTaxiCar in Cars)
            {
                if (baseTaxiCar.MaxSpeed >= minSpeed && baseTaxiCar.MaxSpeed <= maxSpeed)
                {
                   findedCars.Add(baseTaxiCar);
                }
            }
            return findedCars.ToArray();
        }

        static void PrintCars(BaseTaxiCar[] taxiCars)
        {
            foreach (var baseTaxiCar in taxiCars)
            {
                Console.WriteLine(baseTaxiCar);
            }
        }

    }
}