using System.Web.Mvc;
using DAL.Sprints;
using Infrastructure.IOC;
using Task.UnitOfwork;

namespace UI.ActionFilters
{
    public class DatabaseUnitOfWorkActionFilter : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
            base.OnResultExecuted(filterContext);
            Resolve.AnImplementationOf<IDatabaseUnitOfWork>().Commit();
        }
    }
}