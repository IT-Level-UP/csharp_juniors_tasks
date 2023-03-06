namespace Patterns.Structural.Proxy
{
    public class PriceService : IPriceService
    {
        public decimal GetPriceFor(Guid Id)
        {
            var rnd = new Random().NextDouble() * 1000;
            return Math.Round((decimal)rnd, 2);
        }
    }
}
