using System;
using DAL.General;
using DAL.Sprints;

namespace Task.UnitOfwork
{
    public interface IDatabaseUnitOfWork
    {
        void Commit();
    }

    public class DatabaseUnitOfWork : IDatabaseUnitOfWork
    {
        private readonly IDatabase database;

        public DatabaseUnitOfWork(IDatabase database)
        {
            this.database = database;
        }

        public void Commit()
        {
            database.Commit();
        }
    }
}