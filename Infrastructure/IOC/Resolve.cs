using System;


namespace Infrastructure.IOC
{
    public static class Resolve
    {
        private static IDependencyResolver dependencyResolver;

        public static void InitializeWith(IDependencyResolver dependencyResolver)
        {
            Resolve.dependencyResolver = dependencyResolver;
        }

        public static object AnImplementationOf(Type type)
        {
            return dependencyResolver.Implementation(type);
        }

        public static T ImplementationOf<T>()
        {
            return dependencyResolver.ImplementationOf<T>();
        }
    }
}