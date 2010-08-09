using System.Collections.Generic;
using System.Linq;
using DAL.Sprints;
using Domain.Sprints;
using Task.BaseInterfaces;
using UI.Models;

namespace Task.Sprints
{
    public class RetrieveSprintsQuery : IQuery<SprintDto>
    {
        private readonly ISprintRepository sprints;

        public RetrieveSprintsQuery(ISprintRepository sprints)
        {
            this.sprints = sprints;
        }


        public SprintDto Single(long id)
        {
            Sprint sprint = sprints.Find(id);
            return new SprintDto { Id = sprint.Id, Name = sprint.Name, Description = sprint.Description };
        }

        public IEnumerable<SprintDto> All()
        {
            return sprints.All().Select(x => new SprintDto { Id = x.Id, Name = x.Name, Description = x.Description });
        }
    }
}