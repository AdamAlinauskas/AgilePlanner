using DAL.Projects;
using Infrastructure.IOC;
using NUnit.Framework;

namespace UI.Container
{
    [TestFixture]
    public class RegistrySpecs
    {

        [Test]
        public void should()
        {
            ContainerBootStrapper.Initialize();
            var anImplementationOf = Resolve.AnImplementationOf<IProjectRepository>();
            Assert.IsNotNull(anImplementationOf);
        } 

    }
}