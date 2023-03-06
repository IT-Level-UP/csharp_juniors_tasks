namespace Patterns.Behavioral.Strategy
{
    public class RoutePlanningService
    {
        private readonly IRouteStrategy _routeStrategy;

        public RoutePlanningService(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }
        
        public void PlanRoute()
        {
            var routeDetails = _routeStrategy.GetRouteDetails();
            Console.WriteLine($"Transport: {_routeStrategy.TransportType}, duration: {routeDetails.Duration}, price: {routeDetails.Price}");
        }
    }
}
