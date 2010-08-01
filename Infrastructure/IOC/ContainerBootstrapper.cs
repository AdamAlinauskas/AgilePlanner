using IocContainer;

namespace Infrastructure.IOC
{
    public static class ContainerBootstrapper
    {
        public static void Initialize()
        {
            Resolve.InitializeWith(Container.Create());
        }
    }
}