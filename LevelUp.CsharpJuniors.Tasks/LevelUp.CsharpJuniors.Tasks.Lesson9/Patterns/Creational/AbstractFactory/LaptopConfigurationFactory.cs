namespace Patterns.Creational.AbstractFactory
{
    public class LaptopConfigurationFactory : IComputerConfigurationFactory
    {
        public virtual IMotherboard GetMotherboard()
        {
            return new LaptopMotherboard();
        }

        public virtual IProcessor GetProcessor()
        {
            return new LaptopProcessor();
        }

        public virtual IRamModule GetRamModule()
        {
            return new LaptopRamModule();
        }
    }
}
