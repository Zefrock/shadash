using RazorEngine.Text;

namespace shadash.ui.ViewTools
{
    public class ShadashHtmlHelper
    {
        public IEncodedString Raw(string rawString)
        {
            return new RawString(rawString);
        }
    }
}