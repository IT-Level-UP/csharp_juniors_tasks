namespace SolidPrinciples.DIP.Broken
{
    public class DiscountService
    {
        public decimal CalculateDiscount(Client client)
        {
            var discountCalculator = new CategoryBasedDiscountCalculator(client.Category);
            return discountCalculator.Calculate();
        }
    }
}
