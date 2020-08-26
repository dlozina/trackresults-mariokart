using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MarioKart.API.Startup))]

namespace MarioKart.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Nije potrebno zvati Register eksplicitno *** Ruta se postavlja u WebApiConfig klasi
            // WebApiConfig klasi (ruta)
            ConfigureAuth(app);
        }
    }
}
