using System;
using System.Collections.Generic;

namespace AutomaticTelephoneStationEmulator
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
        public void TryCall(Ats ats, Guid contractsId, Guid number)
        {
            if (ats.Contracts.ContainsKey(contractsId))
            {
                ats.Contracts[contractsId].Call(number);
            }
            else
            {
                throw new ArgumentException("Contract with this contractsId doesn't exist");
            }
        }

        public void Answer()
        {

        }

        public void HangUp()
        {

        }

    }
}