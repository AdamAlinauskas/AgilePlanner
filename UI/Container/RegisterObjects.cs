using DAL.General;
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
                         x.AddAllTypesOf(typeof (IQuery<>));
                         x.AddAllTypesOf(typeof (ISaveUpdateCommand<>));
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