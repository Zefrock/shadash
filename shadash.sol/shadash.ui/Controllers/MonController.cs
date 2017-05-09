using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using shadash.ui.Models;
using RazorEngine;
using RazorEngine.Templating;
using RazorEngine.Configuration;
using shadash.ui.ViewTools;

namespace shadash.ui.Controllers
{
    public class MonController : ApiController
    {
        public IRazorEngineService Razor { get; set; }

        public MonController()
        {
            FluentTemplateServiceConfiguration config = new FluentTemplateServiceConfiguration(cfg =>
            {
                cfg.ActivateUsing(ctx =>
                {
                    return new ShadashRazorTemplateBase("http://localhos:9000/shadash");
                });
                cfg.DisableTempFileLocking();
                cfg.WithBaseTemplateType(typeof(ShadashRazorTemplateBase));
                cfg.ManageUsing(new DelegateTemplateManager((tName) =>
                {
                    return File.ReadAllText($@"./Views/{tName}");
                }));

            });

            Razor = RazorEngineService.Create(config);
        }

        private static readonly List<State> statemon = new List<State>
        {

        new State
            {
                Id = 1,
                FirstName = "Thing 1",
                LastName = "Simpson"
            },
            new State
            {
                Id = 2,
                FirstName = "Thing 1",
                LastName = "Simpson"
            },
            new State
            {
                Id = 3,
                FirstName = "Thing 1",
                LastName = "Simpson"
            },
        };


        [HttpGet]
        public HttpResponseMessage Get()
        {
            return this.View("mon.cshtml");
        }

        [HttpGet]
        public IHttpActionResult State()
        {
            return Json(statemon);
        }
    }
}
