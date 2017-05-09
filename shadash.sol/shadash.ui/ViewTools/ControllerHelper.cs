using RazorEngine.Templating;
using shadash.ui.Controllers;
using System.Net;
using System.Net.Http;

namespace shadash.ui.ViewTools
{
    public static class ControllerHelper
    {
        public static HttpResponseMessage View(this MonController controller, string templateName)
        {
            string razorResult = controller.Razor.RunCompile(templateName);

            var resp = new HttpResponseMessage(HttpStatusCode.OK);

            resp.Content = new StringContent(razorResult, System.Text.Encoding.UTF8, "text/html");

            return resp;
        }

        public static HttpResponseMessage View<T>(this MonController controller, string templateName, object model)
        {
            string razorResult = controller.Razor.RunCompile(templateName, typeof(T), model);

            var resp = new HttpResponseMessage(HttpStatusCode.OK);

            resp.Content = new StringContent(razorResult, System.Text.Encoding.UTF8, "text/html");

            return resp;
        }
    }
}