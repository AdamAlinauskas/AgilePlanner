using System.Web.Mvc;
using DAL.Sprints;

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
            
            return View(sprints.All());
        }
    }
}
