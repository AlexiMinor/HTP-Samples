using System;

namespace InterfacesSample
{
    public class Plain : IFlyable
    {
        public string Model { get; set; }
        public string Direction { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("Plain fly");
        }
 
    }
}