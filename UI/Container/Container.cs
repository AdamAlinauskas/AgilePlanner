using Infrastructure.IOC;
using IocContainer;
using StructureMap;

namespace UI.Container
{
    public static class Container
    {
        public static IDependencyResolver Create()
        {
            ObjectFactory.Initialize(x => x.AddRegistry(new RegisterObjects()));
            return new StrctureMapDependencyResolver();
        }
    }

   
}