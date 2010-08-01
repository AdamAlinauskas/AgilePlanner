using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Sprints;

namespace DAL.Sprints
{
    public interface ISprintRepository
    {
        IEnumerable<Sprint> All();
    }

    public class SprintRepository : ISprintRepository
    {
        public IEnumerable<Sprint> All()
        {
            return new List<Sprint>
                       {
                           new Sprint(1, "Sprint 1", "IOC Container"),
                           new Sprint(2, "Sprint 2", "Views"),
                           new Sprint(3, "Sprint 3", "AutoMapping"),
                       };
        }
    }
}