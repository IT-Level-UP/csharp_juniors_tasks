namespace Patterns.Structural.Proxy
{
    public interface IPriceService
    {
        decimal GetPriceFor(Guid Id);
    }
}
