using System.Web;
using System.Web.Routing;

namespace RouteConfigExample.CustomSelectors
{
    public class UserAgentSelector : IRouteConstraint
    {
        private string _userAgentSelector;

        public UserAgentSelector(string browser)
        {
            _userAgentSelector = browser;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent.Contains(_userAgentSelector);
        }
    }
}
