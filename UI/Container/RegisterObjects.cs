using DAL.Sprints;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace IocContainer
{
    public class RegisterObjects : Registry
    {
        public RegisterObjects()
        {
            For<ISprintRepository>().Add<SprintRepository>();
        }
    }
}