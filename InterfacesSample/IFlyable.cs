namespace InterfacesSample
{
    public interface IFlyable : IMovable
    {
        const double PI = 3.14;
        static int MaxSpeed = 60; //not recommended
        string Direction { get; set; }

    }
}