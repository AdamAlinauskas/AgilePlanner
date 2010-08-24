using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Projects;
using Infrastructure.Mapping;
using UI.Models;

namespace Task.Projects
{
    public class ProjectMapper : IMapper<Project,ProjectDto>
    {
        public ProjectDto MapFrom(Project item)
        {
            return new ProjectDto{Id = item.Id,Description=item.Description,Name=item.Name};
        }

        public IEnumerable<ProjectDto> MapFrom(IEnumerable<Project> items)
        {
            return items.Select(MapFrom);
        }
    }
}