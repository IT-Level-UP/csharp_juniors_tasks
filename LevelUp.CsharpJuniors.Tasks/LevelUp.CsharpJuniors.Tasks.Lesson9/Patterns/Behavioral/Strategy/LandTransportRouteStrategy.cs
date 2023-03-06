namespace Patterns.Behavioral.Strategy
{
    public class LandTransportRouteStrategy : IRouteStrategy
    {
        public string TransportType => "Bus";
        
        public (int Duration, int Price) GetRouteDetails()
        {
            return (40, 36);
        }
    }
}
