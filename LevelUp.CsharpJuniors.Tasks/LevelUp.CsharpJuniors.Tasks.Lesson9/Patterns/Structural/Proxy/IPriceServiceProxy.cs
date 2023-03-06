namespace Patterns.Structural.Proxy
{
    public interface IPriceServiceProxy
    {
        decimal GetPriceFor(Guid Id);
    }
}
