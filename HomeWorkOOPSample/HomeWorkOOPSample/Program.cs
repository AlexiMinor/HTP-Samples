using System;
using System.Collections.Generic;
using HomeWorkOOPSample.Creator;
using HomeWorkOOPSample.Models;

namespace HomeWorkOOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxiStation = InitTaxiStation();

            taxiStation.PrintCarsInfo();
            #region sample with interface, override, virtual & new

            //    var cargo2 = new CargoCar2() { MaxCargoCapacity = 15};
            //    var x = cargo2.CalculateRidePrice(
            //        new Ride()
            //        {
            //            CargoCapacity = 10, 
            //            Duration = new TimeSpan(15, 0, 0)
            //        });
            //    var y = (cargo2 as CargoCar).CalculateRidePrice(
            //        new Ride()
            //        {
            //            CargoCapacity = 10, 
            //            Duration = new TimeSpan(15, 0, 0)
            //        });
            //    var z =(cargo2 as IPriceRideable).CalculateRidePrice(
            //        new Ride()
            //        {
            //            CargoCapacity = 10, 
            //            Duration = new TimeSpan(15, 0, 0)
            //        });


            //    var luxuryCar = new LuxuryTaxiCar(){ Coefficient = 3};
            //    x = luxuryCar.CalculateRidePrice(
            //        new Ride()
            //        {
            //            Distance = 10,
            //            Duration = new TimeSpan(15, 0, 0)
            //        });
            //    y = (luxuryCar as TaxiCar).CalculateRidePrice(
            //        new Ride()
            //        {
            //            Distance = 10,
            //            Duration = new TimeSpan(15, 0, 0)
            //        });
            //}

            #endregion

            Console.WriteLine($"Total price: {taxiStation.CalculateTotalPrice()}");

            taxiStation.PrintCarsOrderedByFuelConsumption();

            taxiStation.FindCarBySpeed(10);
            //Console.WriteLine(GetRandomString());

        }

        static TaxiStation InitTaxiStation()
        {
            var carProvider = new CarProvider(new BmwCarCreator(), new FordCarCreator());
            var cars = new List<BaseTaxiCar>();
            for (int i = 0; i < new Random().Next(1000); i++)
            {
                var random = new Random().Next(4);
                switch (random)
                {
                    case 0:
                        cars.Add(carProvider.GetCarByManufacturerAndModel("Bmw", "7er"));
                        break;
                    case 1:
                        cars.Add(carProvider.GetCarByManufacturerAndModel("Bmw", "3er"));
                        break;
                    case 2:
                        cars.Add(carProvider.GetCarByManufacturerAndModel("Ford", "Focus"));
                        break;
                    case 3:
                        cars.Add(carProvider.GetCarByManufacturerAndModel("Ford", "Transit"));
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }

            return new TaxiStation(cars.ToArray());
        }

        static TaxiStation ReadTaxiStationDataFromFile()
        {
            var carProvider = new CarProvider(new BmwCarCreator(), new FordCarCreator());
            var cars = new List<BaseTaxiCar>();

            var taxiStationData = FileReader.ReadFile("paste your full path here");

            foreach (var carInfoFromFile in taxiStationData)
            {
                cars.Add(
                    carProvider.GetCarByManufacturerAndModel(
                            carInfoFromFile.Manufacturer, 
                            carInfoFromFile.Model));
            }

            return new TaxiStation(cars.ToArray());
        }


        static string GetRandomString()
        {
            var stringLenght = new Random().Next(10, 15);

            var stringResult = "";

            for (int i = 0; i < stringLenght; i++)
            {
                stringResult += Convert.ToChar(new Random().Next(65, 123));
            }

            return stringResult;
        }

        static string GetRandomStringFromInitedValues()
        {
            var strings = new string[] {"1", "2", "3"};

            return strings[new Random().Next(strings.Length)]; 
        }
    }
}