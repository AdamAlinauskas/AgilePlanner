using System;

namespace Infrastructure.IOC
{
    public interface IDependencyResolver
    {
        T ImplementationOf<T>();
        object Implementation(Type T);
    }

    
}