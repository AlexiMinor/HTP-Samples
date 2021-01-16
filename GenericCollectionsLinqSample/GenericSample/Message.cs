namespace GenericSample
{
    public class Message<TF, T> where TF : Client
                                where T: BankClient
    {
        public TF FromAccount { get; set; }
        public T ToAccount { get; set; }

    }
}