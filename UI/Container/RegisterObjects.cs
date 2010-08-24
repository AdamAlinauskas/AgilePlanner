using DAL.General;
using Infrastructure.Mapping;
using StructureMap.Configuration.DSL;
using Task.BaseInterfaces;

namespace UI.Container
{
    public class RegisterObjects : Registry
    {
        public RegisterObjects()
        {
            RegisterTaskLayer();
            RegisterDataAccessLayer();
        }

        private void RegisterTaskLayer()
        {
            Scan(x =>
                     {
                         x.Assembly(typeof (IQuery<>).Assembly);
                         x.ConnectImplementationsToTypesClosing(typeof (IQuery<>));
                         x.ConnectImplementationsToTypesClosing(typeof (ISaveUpdateCommand<>));
                         x.ConnectImplementationsToTypesClosing(typeof (IMapper<,>));
                         x.WithDefaultConventions();
                     }
                );
        }

        private void RegisterDataAccessLayer()
        {
            For<IDatabase>().HttpContextScoped().Add<Database>();

            Scan(x =>
                     {
                         x.Assembly(typeof (IDatabase).Assembly);
                         x.ExcludeNamespaceContainingType<IDatabase>();
                         x.WithDefaultConventions();
                     }
                );
        }
    }
}