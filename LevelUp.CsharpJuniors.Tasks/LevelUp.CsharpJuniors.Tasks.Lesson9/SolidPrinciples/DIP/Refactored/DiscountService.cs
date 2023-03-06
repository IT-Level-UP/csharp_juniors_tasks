namespace SolidPrinciples.DIP.Refactored
{
    public class DiscountService
    {
        private readonly IDiscountCalculator _discountCalculator;

        public DiscountService(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }
        
        public decimal CalculateDiscount()
        {
            return _discountCalculator.Calculate();
        }
    }
}
