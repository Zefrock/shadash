using Microsoft.Owin;
using Owin;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.FileSystems;

namespace shadash.host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Remap '/' to '.\static\'.
            // Turns on static files and public files.
            app.UseFileServer(new FileServerOptions()
            {
                EnableDirectoryBrowsing = true,
                RequestPath = PathString.Empty,
                FileSystem = new PhysicalFileSystem(@".\static\"),
            });

            shadash.ui.Startup appStartup = new shadash.ui.Startup();
            appStartup.Configuration(app);
        }
    }
}
