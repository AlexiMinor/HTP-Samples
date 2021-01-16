using System;
using System.Collections.Generic;
using AutomaticTelephoneStationEmulator.EventArgsModels;

namespace AutomaticTelephoneStationEmulator
{
    public class Ats
    {
        public List<Call> CallsHistory { get; set; }
        public Dictionary<Guid, Contract> Contracts { get; set; }
        public Dictionary<Guid, Tariff> Tariffs { get; set; }


        public delegate void NotifyReceiverHandler(object sender, CallEventArgs eventArgs);

        public event NotifyReceiverHandler Notify;


        public Ats()
        {
            Tariffs = new Dictionary<Guid, Tariff>();
            Contracts = new Dictionary<Guid, Contract>();
            CallsHistory = new List<Call>();
        }

        public Contract SignContract(Client client, decimal balance, Tariff tariff)
        {
            if (Tariffs.ContainsKey(tariff.Id))
            {
                var contract = new Contract(client, balance, tariff, this);

                Contracts.Add(contract.Id, contract);

                contract.TryCall += ContractOnTryCall;
                contract.Answer += ContractOnAnswer;
                contract.HangUp += ContractOnHangUp;



                return contract;
            }

            return null;

        }

        private void ContractOnHangUp(object sender, CallEventArgs eventargs)
        {
            var call = new Call(Contracts[eventargs.SenderId], Contracts[eventargs.RecieverId], TimeSpan.Zero, CallStatus.Rejected);
            CallsHistory.Add(call);
        }

        private void ContractOnAnswer(object sender, CallEventArgs eventargs)
        {
            var call = new Call(Contracts[eventargs.SenderId], Contracts[eventargs.RecieverId], TimeSpan.Zero, CallStatus.RecieverNonAvailable);
            CallsHistory.Add(call);
        }

        private void ContractOnTryCall(object sender, CallEventArgs callEventArgs)
        {
            var senderContract = (Contract) sender;
            if (Contracts.ContainsKey(callEventArgs.RecieverId))
            {
                if (!Contracts[senderContract.Id].IsActive)
                {
                    CallsHistory.Add(new Call(senderContract, Contracts[callEventArgs.RecieverId], TimeSpan.Zero, CallStatus.SenderNonActive));
                }

                if (Contracts[senderContract.Id].PortStatus == PortStatus.Disabled)
                {
                    CallsHistory.Add(new Call(senderContract, Contracts[callEventArgs.RecieverId], TimeSpan.Zero, CallStatus.SenderNonAvailable));
                }

                if (!Contracts[callEventArgs.RecieverId].IsActive)
                {
                    CallsHistory.Add(new Call(senderContract, Contracts[callEventArgs.RecieverId], TimeSpan.Zero, CallStatus.RecieverNonActive));
                }

                if (Contracts[callEventArgs.RecieverId].PortStatus == PortStatus.Disabled)
                {
                    CallsHistory.Add(new Call(senderContract, Contracts[callEventArgs.RecieverId], TimeSpan.Zero, CallStatus.RecieverNonAvailable));
                }

                if (Contracts[senderContract.Id].IsActive 
                    && Contracts[senderContract.Id].PortStatus == PortStatus.Available
                    && Contracts[callEventArgs.RecieverId].IsActive
                    && Contracts[callEventArgs.RecieverId].PortStatus == PortStatus.Available)
                {
                    Notify.Invoke(this, callEventArgs);

                }
            }
            else
            {
                CallsHistory.Add(new Call(senderContract, null, TimeSpan.Zero, CallStatus.NumberNotInService));
            }
        }
    }
}