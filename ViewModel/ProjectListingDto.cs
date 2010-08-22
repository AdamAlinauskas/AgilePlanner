using System.Collections.Generic;
using UI.Models;

namespace ViewModel
{
    public class ProjectListingDto
    {
        public IEnumerable<ProjectDto> Projects { get; set; }
    }
}