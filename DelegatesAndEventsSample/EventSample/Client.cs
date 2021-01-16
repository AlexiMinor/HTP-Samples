using System;
using System.Collections.Generic;

namespace EventSample
{
    public class Client
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<BankAccount> Accounts { get; private set; }
       
        public Client(List<BankAccount> accountsList, 
            string firstName, 
            string lastName)
        {
            Accounts = accountsList;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
        }
        
        public void CloseAccount(BankAccount account)
        {
            Accounts.Remove(account);
        }

        public void CashWithdraw(int sum)
        {
            foreach (var bankAccount in Accounts)
            {
                if (bankAccount.Sum  >= sum)
                {
                    bankAccount.CashWithdraw(sum);
                    return;
                }
            }

            Console.WriteLine("Not enough money on any account");
        }

        public void PutMoneyOnAccount(Guid id, int sum)
        {
            foreach (var bankAccount in Accounts)
            {
                if (bankAccount.Id == id)
                {
                    bankAccount.PutMoneyOnAccount(sum);
                    return;
                }
                
            }
            Console.WriteLine($"Account with {id} not found");

        }


    }
}