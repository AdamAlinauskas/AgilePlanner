using System.Data.Entity;
using Domain.Projects;
using Domain.Sprints;

namespace DAL.General
{
    public interface IDatabase
    {
        IDbSet<Sprint> Sprints { get; }
        IDbSet<Project> Projects { get; }
        void Save();

        void Commit();
    }

    public class Database : DbContext, IDatabase
    {
        public IDbSet<Sprint> Sprints { get; set; }
        public IDbSet<Project> Projects { get; set; }


        public void Save()
        {
            SaveChanges();
        }

        public void Commit()
        {
            SaveChanges();
        }
    }
}