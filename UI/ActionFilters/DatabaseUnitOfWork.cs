using System.Web.Mvc;
using DAL.Sprints;
using Infrastructure.IOC;

namespace UI.ActionFilters
{
    public class DatabaseUnitOfWork : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
            base.OnResultExecuted(filterContext);
            Resolve.AnImplementationOf<IDatabase>().Commit();
        }
    }
}