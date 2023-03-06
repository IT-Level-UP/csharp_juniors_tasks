namespace Patterns.Structural.Proxy
{
    public class PriceServiceProxy : IPriceServiceProxy
    {
        private readonly IPriceService _priceService;

        public PriceServiceProxy(IPriceService priceService)
        {
            _priceService = priceService;
        }
        
        public decimal GetPriceFor(Guid Id)
        {
            var price = PricesCache.GetCachedPrice(Id) ?? _priceService.GetPriceFor(Id);
            return price;
        }
    }
}
