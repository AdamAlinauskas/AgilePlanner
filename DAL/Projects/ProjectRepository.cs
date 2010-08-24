using System;
using System.Collections.Generic;
using System.Linq;
using DAL.General;
using Domain.Projects;

namespace DAL.Projects
{
    public interface IProjectRepository
    {
        IEnumerable<Project> All();
    }

    public class ProjectRepository : IProjectRepository
    {
        private readonly IDatabase database;

        public ProjectRepository(IDatabase database)
        {
            this.database = database;
        }

        public IEnumerable<Project> All()
        {
            return database.Projects;
        }
    }
}