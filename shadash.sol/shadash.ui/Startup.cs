using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Diagnostics;
using Owin;
using System.Web.Http;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.FileSystems;

[assembly: OwinStartup(typeof(shadash.ui.Startup))]

namespace shadash.ui
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute("DefaultAPI",
                "{controller}/{action}/{id}",
                new { id = RouteParameter.Optional, action = "Get" });

            app.UseErrorPage();

            app.UseWebApi(config);
        }
    }
}
