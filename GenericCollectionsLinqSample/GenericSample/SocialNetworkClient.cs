namespace GenericSample
{
    public class SocialNetworkClient<T> : Client //T->Type, Template
    {
        public static T session;
        public static int A;
        public int Id { get; set; }
        public T PhoneNumber = default(T);

    }
}