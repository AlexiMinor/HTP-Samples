using System;
using AutomaticTelephoneStationEmulator.EventArgsModels;

namespace AutomaticTelephoneStationEmulator
{
    public class Contract
    {
        public Guid Id { get; set; } // phone-Number
        public Ats Ats { get; private set; }
        public Client Client { get; private set; }

        public bool IsActive { get; set; }

        public Tariff Tariff { get; set; }

        public decimal CurrentBalance { get; set; }

        public PortStatus PortStatus { get; set; }


        public delegate void TryCallHandler(object sender, CallEventArgs eventArgs);

        public event TryCallHandler TryCall;
        public event TryCallHandler Answer;
        public event TryCallHandler HangUp;


        public Contract(Client client, decimal currentBalance, Tariff tariff, Ats ats)
        {
            Id = Guid.NewGuid();
            Client = client;
            CurrentBalance = currentBalance;
            IsActive = true;
            PortStatus = PortStatus.Available;
            Tariff = tariff;
            Ats = ats;

            Ats.Notify += NotifyAboutCall;
        }

        private void NotifyAboutCall(object sender, CallEventArgs eventargs)
        {
            if (Id == eventargs.RecieverId)
            {
                Console.WriteLine($"You ({Client.FirstName} {Client.LastName}) have a call from {eventargs.SenderId}");
                Console.WriteLine("Press 'y' for answer");
                var result = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(result) && result?.ToLowerInvariant() == "y")
                {
                    Answer?.Invoke(this, eventargs);
                }
                else
                {
                    HangUp?.Invoke(this, eventargs);
                }
            }
        }


        public void Call(Guid id)
        {
            if (PortStatus==PortStatus.Available && CurrentBalance>=0)
            {
                TryCall?.Invoke(this, new CallEventArgs(){RecieverId = id, SenderId = Id});
            }
        }


    }
}
