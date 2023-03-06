namespace SolidPrinciples.SRP.Broken
{
    public class OrderService
    {
        public void AuthenticateClient(string login)
        {
            // Authentication logic
        }

        public Order[] GetClientOrders()
        {
            // Go to DB for the orders
            return new Order[0];
        }

        public decimal CalculateClientDiscount()
        {
            // Discount calculation
            return 0;
        }

        public Order CreateOrder(IEnumerable<BucketRow> orderDetails)
        {
            // Create and setup new order
            return new Order(orderDetails);
        }

        public void LogAuditInfo(Guid clientId, string action)
        {
        }
    }
}
