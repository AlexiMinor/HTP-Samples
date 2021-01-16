using System;
using System.Collections.Generic;

namespace AutomaticTelephoneStationEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ats = AtsInitialize();


            var clients = ClientsInitialize();


            var pupkinContract = ats.SignContract(clients[0], 25, ats.Tariffs[new Guid("0DE0EF29-C7E9-4B92-8602-1B2A3D2A057E")]);
            var ivanovContract = ats.SignContract(clients[1], 50, ats.Tariffs[new Guid("0DE0EF29-C7E9-4B92-8602-1B2A3D2A057E")]);
            var petrovContract = ats.SignContract(clients[2], 100.5m, ats.Tariffs[new Guid("C7DCCCB6-29CE-4DF2-AC52-1C653363D864")]);

            clients[0].TryCall(ats, pupkinContract.Id, ivanovContract.Id);
        }

        static List<Client> ClientsInitialize()
        {
            var pupkin = new Client() { FirstName = "Vasily", LastName = "Pupkin" };
            var ivanov = new Client() { FirstName = "Ivan", LastName = "Ivanov" };
            var petrov = new Client() { FirstName = "Petr", LastName = "Petrov" };

            return new List<Client>() {pupkin, ivanov, petrov};
        }
        static Ats AtsInitialize()
        {
            var ats = new Ats();

            var tariffCheap = new Tariff()
            {
                Id = new Guid("0DE0EF29-C7E9-4B92-8602-1B2A3D2A057E"),
                Name = "Cheap",
                FromCallPrice = 1.5m,
                ToCallPrice = 0
            };

            var tariffMedium = new Tariff()
            {
                Id = new Guid("C7DCCCB6-29CE-4DF2-AC52-1C653363D864"),
                Name = "Medium",
                FromCallPrice = 2.5m,
                ToCallPrice = 1
            };

            ats.Tariffs.Add(tariffCheap.Id, tariffCheap);
            ats.Tariffs.Add(tariffMedium.Id, tariffMedium);

            return ats;
        }
    }
}
