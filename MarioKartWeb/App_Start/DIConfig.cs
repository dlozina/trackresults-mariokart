using Autofac;
using Autofac.Integration.Mvc;
using MarioKartService.ApplicationServices;
using MarioKartService.ApplicationServices.Interfaces;
using System.Reflection;
using System.Web.Mvc;

namespace MarioKartWeb.App_Start
{
    public static class DIConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<StandingsCalculation>().As<IStandingsCalculation>().InstancePerRequest();
            builder.RegisterType<Tournaments>().As<ITournaments>().InstancePerRequest();
            builder.RegisterType<Drivers>().As<IDrivers>().InstancePerRequest();
            builder.RegisterType<Races>().As<IRaces>().InstancePerRequest();

            builder.RegisterFilterProvider();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}