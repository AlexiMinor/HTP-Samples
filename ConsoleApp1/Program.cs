using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public enum AccountType : int
    {
        Ordinary, // 0
        Deposit //1    
    }

    class Bank<T> where T : Account, new()
    {
        T[] accounts = new T[] {new T(), new T(), new T()};


        public void Open()
        {
            T newAccount = new T();

            T[] tempAccounts =
                new T[accounts.Length + 1]; // создаём новый массив размерностью на 1 больше чем массив аккаунтов
            for (int i = 0; i < accounts.Length; i++) // вызывем цикл перебора всех счетов в массиве
                tempAccounts[i] =
                    accounts
                        [i]; // перезаписываем в массив все счета которые есть в массиве accounts в массив tempAccounts
            tempAccounts[tempAccounts.Length] = newAccount; // добавляем в массив tempAccounts элемент newAccount
            accounts = tempAccounts; // присваеваем массиву accounts все значения массива tempAccounts
            foreach (var i in accounts)
            {
                Console.WriteLine(i);
            }
        }
    }
}