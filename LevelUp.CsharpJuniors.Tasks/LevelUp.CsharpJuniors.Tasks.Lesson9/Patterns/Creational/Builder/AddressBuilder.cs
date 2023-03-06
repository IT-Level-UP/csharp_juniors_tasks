namespace Patterns.Creational.Builder;

public class AddressBuilder
{
    private Address _address = new();

    public AddressBuilder WithCountry(string country)
    {
        _address = _address with { Country = country };
        return this;
    }

    public AddressBuilder WithCity(string city)
    {
        _address = _address with { City = city };
        return this;
    }

    public Address Build() => _address;
}
