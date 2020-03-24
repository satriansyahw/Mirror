using GenHelper.Cache;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.General
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class ValidateHeaderAntiForgery : ActionFilterAttribute
    {
        MemoryCacher cacher = new MemoryCacher();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var allowedMMetode = new[] { "api/LockDoor/RegisterLogin", "api/LockDoor/OpenDoor"
                , "api/LockDoor/GetJalanSetapak", "api/LockDoor/GetDoorChecking","api/Values","api/Values/Get"
                ,"api/Values/GetValue","api/Values/GetSimpanAsync"  };
            StringValues headerValues = "";
            var userId = string.Empty;
            string currentTemplate = filterContext.ActionDescriptor.AttributeRouteInfo.Template;
            string checker = string.Empty;
            string TheSun = string.Empty;
            if (allowedMMetode.Contains(currentTemplate))
            {
                string akuboleh = "";
            }
            else
            {
                if (filterContext.HttpContext.Request.Headers.TryGetValue("TheSun", out headerValues))
                {
                    TheSun = headerValues.FirstOrDefault();
                }
                if (TheSun == "TheSun")
                {
                    throw new ArgumentNullException("filterContext");
                }
                else
                {
                    if (TheSun.Contains("TheSun"))
                    {
                        checker = TheSun.Replace("TheSun", string.Empty);
                        var checkerResult = cacher.GetValue(checker);
                        if (checkerResult == null)
                        {
                            throw new ArgumentNullException("filterContext");

                        }
                        else
                        {

                        }

                    }
                    else
                    {
                        throw new ArgumentNullException("filterContext");

                    }
                }
            }

        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string a = string.Empty;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string a = string.Empty;
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string a = string.Empty;
        }
    }
}
