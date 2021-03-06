using Autofac;
using Autofac.Integration.WebApi;
using MarioKartService.ApplicationServices;
using MarioKartService.ApplicationServices.Interfaces;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace MarioKart.API.App_Start
{
    public static class DIConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<StandingsCalculation>().As<IStandingsCalculation>().InstancePerRequest();
            builder.RegisterType<Tournaments>().As<ITournaments>().InstancePerRequest();
            builder.RegisterType<Drivers>().As<IDrivers>().InstancePerRequest();
            builder.RegisterType<Races>().As<IRaces>().InstancePerRequest();
            builder.RegisterType<AppInformations>().As<IAppInformations>().InstancePerRequest();

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}