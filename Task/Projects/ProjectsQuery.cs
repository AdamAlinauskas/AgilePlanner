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
        private readonly IProjectsRepository projects;
        private readonly IMapper<Project, ProjectDto> mapper;

        public ProjectsQuery(IProjectsRepository projects, IMapper<Project, ProjectDto> mapper)
        {
            this.projects = projects;
            this.mapper = mapper;
        }

        public ProjectDto Single(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectDto> All()
        {
            return mapper.MapFrom(projects.All());
        }
    }
}