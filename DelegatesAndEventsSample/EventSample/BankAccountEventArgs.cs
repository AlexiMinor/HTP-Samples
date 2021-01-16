using System;

namespace EventSample
{
    public class BankAccountEventArgs //event arguments
    {
        public Guid Id { get;  }
        public string Message { get; }

        public BankAccountEventArgs(Guid id, string message)
        {
            Id = id;
            Message = message;
        }
    }
}