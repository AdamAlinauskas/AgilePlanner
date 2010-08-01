using System;

namespace Domain.Sprints
{
    public class Sprint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Sprint(int id, string Name, string Description)
        {
            Id = id;
            this.Name = Name;
            this.Description = Description;
        }
    }
}