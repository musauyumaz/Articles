using System.Reflection;
using System.Web.Mvc;

namespace RouteConfigExample.CustomAttributes
{
    public class Explorer : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.UserAgent.Contains("Trident");
        }
    }
}
