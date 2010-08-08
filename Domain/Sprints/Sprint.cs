using System;

namespace Domain.Sprints
{
    public class Sprint
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Sprint()
        {
        }

        public Sprint(long Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }

        public void Update(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}