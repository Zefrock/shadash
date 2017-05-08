using shadash.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace shadash.host
{
    class Program
    {
        static void Main(string[] args)
        {
            var svcUrl = "http://localhost:9000/shadash/";

            var host = HostFactory.New((config) =>
            {
                config.Service<ShadashService>((service) =>
                    {
                        service.ConstructUsing(() => new ShadashService(svcUrl));
                        service.WhenStarted(s => s.Start());
                        service.WhenStopped(s => s.Stop());
                    });
            });


            host.Run();
        }
    }
}
