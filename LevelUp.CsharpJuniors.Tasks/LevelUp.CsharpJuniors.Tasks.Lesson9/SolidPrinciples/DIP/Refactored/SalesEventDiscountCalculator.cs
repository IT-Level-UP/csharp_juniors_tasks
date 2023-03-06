namespace SolidPrinciples.DIP.Refactored
{
    public class SalesEventDiscountCalculator : IDiscountCalculator
    {
        private readonly Guid _eventId;

        public SalesEventDiscountCalculator(Guid eventId)
        {
            _eventId = eventId;
        }

        public decimal Calculate()
        {
            // Get event by id, calculate discount...
            return 10;
        }
    }
}
