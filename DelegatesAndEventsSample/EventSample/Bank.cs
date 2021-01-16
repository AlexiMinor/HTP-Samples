using System;
using System.Collections.Generic;

namespace EventSample
{
    public class Bank
    {
        private List<string> _operationHistory = new List<string>();

        public List<Client> Clients { get; private set; }
        
        public Bank(List<Client> clients)
        {
            Clients = clients;

            foreach (var client in clients)
            {
                foreach (var clientAccount in client.Accounts)
                {
                    clientAccount.Notify += NotifyUser;
                }


            }
        }

        public void AddOperationToHistory(string message)
        {
            _operationHistory.Add(message);

        }

        private void NotifyUser(object sender, BankAccountEventArgs eventArgs)
        {
            AddOperationToHistory(eventArgs.Message);
            foreach (var client in Clients)
            {
                foreach (var clientAccount in client.Accounts)
                {
                    if (clientAccount.Id == eventArgs.Id)
                    {
                        Console.WriteLine($"{client.FirstName} {client.LastName} - {eventArgs.Message}. Current account sum {((BankAccount)sender).Sum}");
                    }
                }
            }
        }
    }
}