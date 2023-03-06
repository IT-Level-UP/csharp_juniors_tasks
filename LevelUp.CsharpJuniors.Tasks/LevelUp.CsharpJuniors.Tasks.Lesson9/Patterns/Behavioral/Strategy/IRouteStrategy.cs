namespace Patterns.Behavioral.Strategy
{
    public interface IRouteStrategy
    {
        string TransportType { get; }

        (int Duration, int Price) GetRouteDetails();
    }
}
