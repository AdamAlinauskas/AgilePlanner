using DAL.Sprints;
using Domain.Sprints;
using Task.BaseInterfaces;
using UI.Models;

namespace Task.Sprints
{
    public class SaveUpdateSprintCommand : ISaveUpdateCommand<SprintDto>
    {
        private readonly ISprintRepository sprints;

        public SaveUpdateSprintCommand(ISprintRepository sprints)
        {
            this.sprints = sprints;
        }

        public void Save(SprintDto dto)
        {
            if(dto.Id.Equals(0))
                sprints.Save(new Sprint(dto.Name,dto.Description));
            else
                sprints.Find(dto.Id).Update(dto.Name,dto.Description);
        }
    }
}