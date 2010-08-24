using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Projects;
using Domain.Projects;
using Infrastructure.Mapping;
using Infrastructure.Testing;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Interfaces;
using Task.BaseInterfaces;
using UI.Models;

namespace Task.Projects
{
    public class ProjectQuerySpecs
    {
        public abstract class behaves_like_a_ProjectsQuery : ContextSpec<IQuery<ProjectDto>>
        {
            protected IProjectRepository Project;
            protected IMapper<Project, ProjectDto> mapper;

            public override IQuery<ProjectDto> CreateSut()
            {
                Project = MockRepository.GenerateStub<IProjectRepository>();
                mapper = MockRepository.GenerateMock<IMapper<Project, ProjectDto>>();
                return new ProjectsQuery(Project,mapper);
            }
        }

        public class when_retrieving_all_projects: behaves_like_a_ProjectsQuery
        {
            private IEnumerable<ProjectDto> result;
            private IEnumerable<Project> allProjects;
            private IEnumerable<ProjectDto> mappedProjects;

            public override void UnderTheseConditions()
            {
                allProjects = Enumerable.Empty<Project>();
                mappedProjects = Enumerable.Empty<ProjectDto>();

                Project.Stub(x => x.All()).Return(allProjects);
                mapper.Stub(x => x.MapFrom(allProjects)).Return(mappedProjects);
            }

            public override void BecauseOf()
            {
                result = sut.All();
            }

            [Test]
            public void it_should_return_the_value_from_the_repository()
            {
                result.ShouldBeEqualTo(mappedProjects);
            } 
        }
    }

    
}