namespace GenericSample
{
    public class ClientProfile<T> where T : Client
    {
        public T Client { get; private set; }

        public string Url { get; set; }

        public ClientProfile(T client)
        {
            Client = client;
        }

        public void Do()
        {
            if (Client is BankClient client)
            {
                client.SpecialMethod();
            }
            
        }
       
    }
}