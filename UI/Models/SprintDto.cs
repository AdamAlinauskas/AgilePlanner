using System;

namespace UI.Models
{
    public class SprintDto
    {
        [HiddenField]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}