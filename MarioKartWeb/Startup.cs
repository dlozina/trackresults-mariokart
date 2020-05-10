using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarioKartWeb.Startup))]
namespace MarioKartWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
