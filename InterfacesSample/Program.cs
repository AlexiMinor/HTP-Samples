using System;

namespace InterfacesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var pl = new Plain();
            var hc = new Helicopter();
            
            Fly(pl);
            Fly(hc);
        }

        static void Fly(IFlyable obj)
        {
            obj.Move();
        }
    }
}
