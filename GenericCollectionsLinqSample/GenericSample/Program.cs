using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client1 = new SocialNetworkClient<int>()
            //{
            //    Id = 1,
            //    PhoneNumber = 801111111
            //};
            //SocialNetworkClient<int>.A = 15;
            //SocialNetworkClient<int>.session = 15;

            //SocialNetworkClient<string>.session = "16";

            //Console.WriteLine(SocialNetworkClient<int>.A);
            //Console.WriteLine(SocialNetworkClient<int>.session);
            //Console.WriteLine(SocialNetworkClient<string>.A);
            //Console.WriteLine(SocialNetworkClient<string>.session);

            //var specObj = new Message<int, string, long, DateTime>();

            //var client2 = new SocialNetworkClient<string>()
            //{
            //    Id = 1,
            //};
            //var client2Phone = client2.PhoneNumber;
            //var client3 = new SocialNetworkClient<List<string>>()
            //{
            //    Id = 1
            //};
            //if (client3.PhoneNumber.Any())
            //{
            //    Console.WriteLine("true");
            //}

            //Do(client3, out List<string> x);

            //Do2<int>();

            var client1 = new SocialNetworkClient<int>()
            {
                Id = 1,
                PhoneNumber = 801111111
            };

            var socialNetworkClientProfile = new ClientProfile<SocialNetworkClient<int>>(client1);

            var obj1 = new ChildClass1<string>("1");

            var obj2 = new ChildClass2(1);
            var obj3 = new ChildClass1<int>(2);

            var list = new List<ParentClass<int>>();

            list.Add(obj2);
            list.Add(obj3);
            //list.Add(obj1);


        }

        static void Do2<T>()
        {
            Console.WriteLine(default(T));
        }

        static void Do<T>(SocialNetworkClient<T> arg, out T par)
        {
            T phone = arg.PhoneNumber;
            if (phone != null)
            {
                par = phone;
            }

            par = default;
        }
    }
}
