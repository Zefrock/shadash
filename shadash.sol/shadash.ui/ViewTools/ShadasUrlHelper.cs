using System.IO;

namespace shadash.ui.ViewTools
{
    public class ShadasUrlHelper
    {
        private string _url;

        public ShadasUrlHelper(string url)
        {
            _url = url;
        }

        public string Script(string scriptFileName)
        {
            return Path.Combine(_url, "Scripts", scriptFileName);
        }

        public string Content(string contentFileName)
        {
            
            return Path.Combine(_url, "Content", contentFileName);
        }

    }
}