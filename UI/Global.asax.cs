using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Infrastructure.IOC;
using IocContainer;
using UI.Container;

namespace UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new {controller = "Sprint", action = "Index", id = UrlParameter.Optional} // Parameter defaults
                );
        }

        protected void Application_Start()
        {
            BootStrapper.Initialize();
            
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);

        }
    }

    public static class BootStrapper
    {
        public static void Initialize()
        {
            ContainerBootStrapper.Initialize();
            ControllerBuilder.Current.SetControllerFactory(new CustomContorllerFactory());
        }
    }

    public class CustomContorllerFactory : DefaultControllerFactory
    {

        protected override IController GetControllerInstance(RequestContext requestContext, System.Type controllerType)
        {
            return Resolve.AnImplementationOf(controllerType) as IController;
        }
    }
}