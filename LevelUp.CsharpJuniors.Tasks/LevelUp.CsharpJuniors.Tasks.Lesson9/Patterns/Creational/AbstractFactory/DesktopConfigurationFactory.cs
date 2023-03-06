namespace Patterns.Creational.AbstractFactory
{
    public class DesktopConfigurationFactory : IComputerConfigurationFactory
    {
        public virtual IMotherboard GetMotherboard()
        {
            return new DesktopMotherboard();
        }

        public virtual IProcessor GetProcessor()
        {
            return new DesktopProcessor();
        }

        public virtual IRamModule GetRamModule()
        {
            return new DesktopRamModule();
        }
    }
}
