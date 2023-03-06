namespace Patterns.Creational.Builder;

public sealed record Address
{
    public string? Country { get; init; }
    public string? City { get; init; }

    public override string ToString()
    {
        return $"Country: {Country}\nCity: {City}";
    }
}