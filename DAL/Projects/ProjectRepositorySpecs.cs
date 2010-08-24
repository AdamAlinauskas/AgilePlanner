using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.General;
using Domain.Projects;
using Infrastructure.Testing;
using NUnit.Framework;
using Rhino.Mocks;

namespace DAL.Projects
{
    public class ProjectRepositorySpecs
    {
        public abstract class behaves_like_a_ProjectRepository : ContextSpec<IProjectRepository>
        {
            protected IDatabase database;

            public override IProjectRepository CreateSut()
            {
                database = MockRepository.GenerateMock<IDatabase>();
                return new ProjectRepository(database);
            }
        }
        
       public class when_retrieving_all_projects : behaves_like_a_ProjectRepository
       {
           public override void UnderTheseConditions()
           {
//               IEnumerable<Project> allProjects = Enumerable.Empty<Project>();
//               database.Stub(x => x.Projects).Return(allProjects);
           }

           public override void BecauseOf()
           {
               sut.All();
           }


           [Test]
           public void it_should_have_retrieved_all_projects()
           {

           } 
       }
    }
}