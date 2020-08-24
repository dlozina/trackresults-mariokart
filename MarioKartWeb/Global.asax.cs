using MarioKart.Utility;
using MarioKartWeb.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MarioKartWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // AutoMapper
            AutoMapperConfig.Configure();
            // DI configure
            DIConfig.Configure();
            // Log4net configure
            // Initialize log4net.
            log4net.Config.XmlConfigurator.Configure();
            logger.Debug("Log4net config init");
            // Get app data folder path
            FolderUtility.GetMarioKartProcessingWebRootFolder();
            logger.Debug("Web started!");
        }
    }
}