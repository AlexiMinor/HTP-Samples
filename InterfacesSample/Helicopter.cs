using System;

namespace InterfacesSample
{
    public class Helicopter : IFlyable
    {
        public string Direction { get; set; }
        public void Fly()
        {
            Console.WriteLine("Helicopter fly");
        }
    }
}