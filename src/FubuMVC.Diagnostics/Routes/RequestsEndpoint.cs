using HtmlTags;

namespace FubuMVC.Diagnostics.Requests
{
    public class RoutesEndpoint
    {
        public HtmlTag get_routes(RoutesRequest request)
        {
            return new HtmlTag("H1").Text("Request Explorer (Forthcoming)");
        }
    }

    public class RoutesRequest{}
}