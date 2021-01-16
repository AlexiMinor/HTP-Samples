using System;

namespace AutomaticTelephoneStationEmulator
{
    public class Tariff
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public decimal FromCallPrice { get; set; } //call from client
        public decimal ToCallPrice { get; set; } //call to client
    }
}