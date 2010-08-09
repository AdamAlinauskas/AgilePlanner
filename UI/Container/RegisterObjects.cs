using DAL.Sprints;
using StructureMap.Configuration.DSL;
using Task.BaseInterfaces;
using Task.Sprints;
using Task.UnitOfwork;
using UI.Models;
using StructureMap;

namespace IocContainer
{
    public class RegisterObjects : Registry
    {
        public RegisterObjects()
        {
            For<ISprintRepository>().Add<SprintRepository>();
            For<IQuery<SprintDto>>().Add<RetrieveSprintsQuery>();
            For<ISaveUpdateCommand<SprintDto>>().Add<SaveUpdateSprintCommand>();
            For<IDatabaseUnitOfWork>().Add<DatabaseUnitOfWork>();
            
            For<IDatabase>().HttpContextScoped().Add<Database>();
            

        }
    }
}