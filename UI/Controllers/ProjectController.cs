using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.BaseInterfaces;
using UI.Models;
using ViewModel;

namespace UI.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IQuery<ProjectDto> query;

        public ProjectController(IQuery<ProjectDto> query)
        {
            this.query = query;
        }

        //
        // GET: /Project/

        public ViewResult Index()
        {
            return View(new ProjectListingDto {Projects = query.All()});
        }

        public ViewResult AddEdit(object id)
        {
            throw new NotImplementedException();
        }
    }
}
