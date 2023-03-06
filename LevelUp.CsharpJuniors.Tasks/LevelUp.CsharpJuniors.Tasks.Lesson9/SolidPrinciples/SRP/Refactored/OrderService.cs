namespace SolidPrinciples.SRP.Refactored
{
    public class OrderService
    {
        public Order[] GetClientOrders()
        {
            // Go to DB for the orders
            return new Order[0];
        }

        public Order CreateOrder(IEnumerable<BucketRow> orderDetails)
        {
            // Create and setup new order
            return new Order(orderDetails);
        }
    }

    public class AuthenticationService
    {
        public void AuthenticateClient(string login)
        {
            // Authentication logic
        }
    }

    public class DiscountService
    {
        public decimal CalculateClientDiscount()
        {
            // Discount calculation
            return 0;
        }
    }

    public class Logger
    {
        public void LogAuditInfo(Guid clientId, string action)
        {
        }
    }
}
