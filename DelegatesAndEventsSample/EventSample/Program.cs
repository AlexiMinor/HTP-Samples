using System;
using System.Collections.Generic;

namespace EventSample
{
    class Program
    {
        static void Main(string[] args)
        {

            var bankAccount1 = new BankAccount(100);
            var bankAccount2 = new BankAccount(200);
            var bankAccount3 = new BankAccount(300);
            var bankAccount4 = new BankAccount(500);
            var bankAccount5 = new BankAccount(5000.15m);
            var bankAccount6 = new BankAccount(3000.15m);

            var clientPetya = new Client(new List<BankAccount>(){bankAccount1, bankAccount2}, "Petya", "Ivanov" );
            var clientVasya = new Client(new List<BankAccount>(){ bankAccount3, bankAccount4, bankAccount5, bankAccount6 }, "Vasya", "Pupkin" );

            var bank = new Bank(new List<Client>(){clientPetya, clientVasya});
         
            clientPetya.PutMoneyOnAccount(bankAccount1.Id, 100);
            clientVasya.CashWithdraw(200);

        }
        //    var bankAccount1 = new BankAccount(5000.15m);
        //    bankAccount1.Notify += NotifyOnEmail;
        //    var bankAccount2 = new BankAccount(0);
        //    bankAccount2.Notify += Notify;
        //    var bankAccount3 = new BankAccount(50.55m);
        //    bankAccount3.Notify += NotifyOnSms;

        //    var collection = new List<BankAccount> { bankAccount1, bankAccount2, bankAccount3 };
        //    var clientPetya = new Client(collection, "email", "phone");

        //    var bank = new Bank(10000);
        //    bankAccount1.Notify += bank.ChangeTotalSum;

        //    clientPetya.CashWithdraw(15);
        //    clientPetya.CashWithdraw(70);
        //    clientPetya.PutMoneyOnAccount(clientPetya.Accounts[1].Id, 70);
        //    clientPetya.CashWithdraw(4900);
        //    clientPetya.CashWithdraw(60);

        //    foreach (var clientPetyaAccount in clientPetya.Accounts)
        //    {
        //        Console.WriteLine(clientPetyaAccount.Sum);
        //    }
        //}



        //static void Notify(string message, decimal sum)
        //{
        //    Console.WriteLine($"{message}");
        //}

        //static void NotifyOnEmail(string message, decimal sum)
        //{
        //    Console.WriteLine($"Email: {message}");
        //}

        //static void NotifyOnSms(string message, decimal sum)
        //{
        //    Console.WriteLine($"Sms: {message}");
        //}
    }
}
