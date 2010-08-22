using System;
using System.Collections.Generic;
using Domain.Projects;

namespace DAL.Projects
{
    public interface IProjectsRepository
    {
        IEnumerable<Project> All();
    }

    public class ProjectsRepository : IProjectsRepository
    {
        public IEnumerable<Project> All()
        {
            throw new NotImplementedException();
        }
    }
}