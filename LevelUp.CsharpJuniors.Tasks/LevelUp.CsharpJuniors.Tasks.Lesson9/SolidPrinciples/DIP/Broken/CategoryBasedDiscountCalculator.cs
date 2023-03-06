namespace SolidPrinciples.DIP.Broken
{
    public class CategoryBasedDiscountCalculator
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
