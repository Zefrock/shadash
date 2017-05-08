using Microsoft.Owin.Hosting;

namespace shadash.host
{
    public class ShadashService
    {
        private string _url;

        public ShadashService(string url)
        {
            _url = url;
        }
        public void Start()
        {
            var app = WebApp.Start<Startup>(_url);
        }
        public void Stop() { }
    }
}
