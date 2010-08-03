using Infrastructure.IOC;

namespace UI.Container
{
    public class ContainerBootStrapper
    {
        public static void Initialize()
        {
            Resolve.InitializeWith(Container.Create());
        }
    }
}