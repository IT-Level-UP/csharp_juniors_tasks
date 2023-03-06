namespace Patterns.Creational.AbstractFactory
{
    public interface IComputerConfigurationFactory
    {
        IMotherboard GetMotherboard();

        IProcessor GetProcessor();

        IRamModule GetRamModule();
    }
}
