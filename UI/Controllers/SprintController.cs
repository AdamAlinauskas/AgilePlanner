using System;
using System.Web.Mvc;
using DAL.Sprints;
using System.Linq;
using Domain.Sprints;
using MvcContrib.ActionResults;
using UI.ActionFilters;
using UI.Models;
using Microsoft.Web.Mvc;

namespace UI.Controllers
{
    [DatabaseUnitOfWork]
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


            Sprint sprint = sprints.Find(id);

            return View( new SprintDto { Id = sprint.Id, Name = sprint.Name, Description = sprint.Description });
        }

        [HttpPost]
        public ActionResult AddEdit(SprintDto dto)
        {
            if (dto.Id.Equals(0))
                sprints.Save(new Sprint(dto.Id, dto.Name, dto.Description));
            else
                sprints.Find(dto.Id).Update(dto.Name, dto.Description);

            return new RedirectToRouteResult<SprintController>(x => x.Index());
        }
    }
}
