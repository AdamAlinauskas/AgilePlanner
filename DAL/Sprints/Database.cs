using System.Data.Entity;
using Domain.Sprints;

namespace DAL.Sprints
{
    public interface IDatabase
    {
        IDbSet<Sprint> Sprints { get; }
        void Save();
    }

    public class Database : DbContext, IDatabase
    {
        public IDbSet<Sprint> Sprints { get; set; }

        public void Save()
        {
            SaveChanges();
        }
    }
}