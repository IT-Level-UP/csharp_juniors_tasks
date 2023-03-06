using Patterns;
using Patterns.Behavioral.Strategy;
using Patterns.Creational.AbstractFactory;
using Patterns.Creational.Builder;
using Patterns.Structural.Proxy;

// Abstract factory using

var desktopFactory = new DesktopConfigurationFactory();

var motherboard = desktopFactory.GetMotherboard();
Console.WriteLine(motherboard.ProductType);

var processor = desktopFactory.GetProcessor();
Console.WriteLine(processor.ProductType);

var ramModule = desktopFactory.GetRamModule();
Console.WriteLine(ramModule.ProductType);


var laptopFactory = new LaptopConfigurationFactory();

motherboard = laptopFactory.GetMotherboard();
Console.WriteLine(motherboard.ProductType);

processor = laptopFactory.GetProcessor();
Console.WriteLine(processor.ProductType);

ramModule = laptopFactory.GetRamModule();
Console.WriteLine(ramModule.ProductType);

// Strategy using

var metroRoutePlanningService = new RoutePlanningService(new MetroRouteStrategy());
metroRoutePlanningService.PlanRoute();

var landTransportRoutePlanningService = new RoutePlanningService(new LandTransportRouteStrategy());
landTransportRoutePlanningService.PlanRoute();

// Builder using

var builder = new AddressBuilder()
    .WithCountry("Russia")
    .WithCity("Spb");

var address = builder.Build();
Console.WriteLine(address);

// Proxy using

var priceService = new PriceService();
var proxy = new PriceServiceProxy(priceService);

var productId = Guid.NewGuid();
var price = proxy.GetPriceFor(productId);
Console.WriteLine($"Price for producti with ID '{productId}' is {price}");

