using System;

namespace EventSample
{
    public class BankAccount
    {
        public delegate void AccountSumChangesHandler(object sender, BankAccountEventArgs e);
        public event AccountSumChangesHandler Notify;


        public Guid Id { get; private set; }
        public decimal Sum { get; private set; }

        public BankAccount(decimal sum)
        {
            Id = Guid.NewGuid();
            Sum = sum;
        }

        public void PutMoneyOnAccount(decimal sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new BankAccountEventArgs(Id, $"{sum} added to account {Id} "));
        }

        public void CashWithdraw(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new BankAccountEventArgs(Id, $"Withdraw {sum} from account {Id} "));
            }
        }

        public void Pay(decimal sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new BankAccountEventArgs(Id, $"Payment on {sum} from account {Id} "));
            }
        }
    }
}