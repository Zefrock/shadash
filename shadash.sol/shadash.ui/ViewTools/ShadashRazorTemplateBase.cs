using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shadash.ui.ViewTools
{
    public class ShadashRazorTemplateBase : TemplateBase
    {
        public ShadashRazorTemplateBase(string url)
        {
            Html = new ShadashHtmlHelper();
            Url = new ShadasUrlHelper(url);
        }

        public ShadashHtmlHelper Html { get; set; }
        public ShadasUrlHelper Url { get; set; }
    }
}