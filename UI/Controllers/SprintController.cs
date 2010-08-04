using System;
using System.Web.Mvc;
using DAL.Sprints;
using System.Linq;
using UI.Models;

namespace UI.Controllers
{
    public class SprintController : Controller
    {
        private readonly ISprintRepository sprints;

        public SprintController(ISprintRepository sprints)
        {
            this.sprints = sprints;
        }

        public ActionResult Index()
        {
            return View(sprints.All().Select(x => new SprintDto{Id=x.Id,Name=x.Name,Description = x.Description}));
        }

        public ViewResult AddEdit(long id)
        {
            if (id.Equals(0))
                return View();

            return null;
        }
    }
}
