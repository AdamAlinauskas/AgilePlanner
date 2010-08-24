using System;
using System.Collections.Generic;
using DAL.Projects;
using Domain.Projects;
using Infrastructure.Mapping;
using Task.BaseInterfaces;
using UI.Models;

namespace Task.Projects
{
    public class ProjectsQuery : IQuery<ProjectDto>
    {
        private readonly IProjectRepository Project;
        private readonly IMapper<Project, ProjectDto> mapper;

        public ProjectsQuery(IProjectRepository Project, IMapper<Project, ProjectDto> mapper)
        {
            this.Project = Project;
            this.mapper = mapper;
        }

        public ProjectDto Single(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectDto> All()
        {
            return mapper.MapFrom(Project.All());
        }
    }
}