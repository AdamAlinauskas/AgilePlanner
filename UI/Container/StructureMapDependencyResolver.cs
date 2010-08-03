using System;
using Infrastructure.IOC;
using StructureMap;

namespace UI.Container
{
    public class StrctureMapDependencyResolver : IDependencyResolver
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