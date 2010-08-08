using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Sprints;

namespace DAL.Sprints
{
    public interface ISprintRepository
    {
        IEnumerable<Sprint> All();
        void Save(Sprint sprint);
    }

    public class SprintRepository : DbContext,ISprintRepository
    {
        private readonly IDatabase database;


        public SprintRepository(IDatabase database)
        {
            this.database = database;
        }

        public Sprint FindBy(long ID)
        {
            return database.Sprints.Find(ID);
        }

        public IEnumerable<Sprint> All()
        {
            return database.Sprints.ToList();
        }

        public void Save(Sprint sprint)
        {
            database.Sprints.Add(sprint);
            database.Save();
        }
    }
}