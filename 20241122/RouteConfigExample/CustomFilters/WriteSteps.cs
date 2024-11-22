using System;
using System.Web.Mvc;

namespace RouteConfigExample.CustomFilters
{
    [AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = true)]
    public class WriteSteps : ActionFilterAttribute
    {
        public WriteSteps(string message)
        {
            Message = message;
        }
        public string Message { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(Message + " İşlemine Başlandı. </br>");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(Message + " İşlemi Bitirildi. </br>");
        }
    }
}
