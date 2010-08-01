using System;
using StructureMap;

namespace IocContainer
{
    public static class Container
    {
        public static IDependencyResolver Create()
        {
            ObjectFactory.Initialize(x => x.AddRegistry(new RegisterObjects()));
            return new DependencyResolver();
        }
    }

    public interface IDependencyResolver
    {
        T ImplementationOf<T>();
        object Implementation(Type T);
    }

    public class DependencyResolver : IDependencyResolver
    {
        public T ImplementationOf<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }

        public object Implementation(Type T)
        {
            return ObjectFactory.GetInstance(T);
        }
    }
}