using shadash.ui.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace shadash.ui.Controllers
{
    public class MonController : ApiController
    {
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
            //maybe use some razor to resolve a page
            var singlePageApp = File.ReadAllText(@".\Pages\mon.html");

            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new StringContent(singlePageApp, System.Text.Encoding.UTF8, "text/html");
            return resp;
        }

        [HttpGet]
        public IHttpActionResult State()
        {
            return Json(statemon);
        }
    }
}
