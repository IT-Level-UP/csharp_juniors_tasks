namespace SolidPrinciples.DIP.Refactored
{
    public class CategoryBasedDiscountCalculator : IDiscountCalculator
    {
        private readonly int _category;

        public CategoryBasedDiscountCalculator(int category)
        {
            _category = category;
        }

        public decimal Calculate()
        {
            return _category * 10;
        }
    }
}
