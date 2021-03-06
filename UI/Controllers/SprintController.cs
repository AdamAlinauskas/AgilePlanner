﻿using System.Web.Mvc;
using MvcContrib.ActionResults;
using Task.BaseInterfaces;
using UI.ActionFilters;
using UI.Models;

namespace UI.Controllers
{
    [DatabaseUnitOfWorkActionFilter]
    public class SprintController : Controller
    {
        private readonly IQuery<SprintDto> retrieveSprintsQuery;
        private readonly ISaveUpdateCommand<SprintDto> saveCommand;

        public SprintController(IQuery<SprintDto> retrieveSprintsQuery,ISaveUpdateCommand<SprintDto> saveCommand)
        {
            this.retrieveSprintsQuery = retrieveSprintsQuery;
            this.saveCommand = saveCommand;
        }
        
        public ViewResult Index()
        {
            return View(retrieveSprintsQuery.All());
        }

        public ViewResult AddEdit(long id)
        {
            if (id.Equals(0))
                return View();

            return View(retrieveSprintsQuery.Single(id));
        }

        [HttpPost]
        public ActionResult AddEdit(SprintDto dto)
        {
            saveCommand.Save(dto);
            return new RedirectToRouteResult<SprintController>(x => x.Index());
        }
    }

    
}
