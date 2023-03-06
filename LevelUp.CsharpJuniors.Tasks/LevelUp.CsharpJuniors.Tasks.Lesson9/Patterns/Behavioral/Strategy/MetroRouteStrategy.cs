namespace Patterns.Behavioral.Strategy
{
    public class MetroRouteStrategy : IRouteStrategy
    {
        public string TransportType => "Metro";

        public (int Duration, int Price) GetRouteDetails()
        {
            return (25, 45);
        }
    }
}
