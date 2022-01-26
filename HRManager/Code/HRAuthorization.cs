using HRManager.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HRManager.Code
{
    public class HRAuthorization: Attribute, IAuthorizationFilter
    {
        private string _RequiredRole = string.Empty;

         public HRAuthorization(string RequiredRole)
        {
            _RequiredRole = RequiredRole;
        }
        
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(!Code.Session.UserRoles.Contains(_RequiredRole))
            {
                var errorNumber = ErrorLogger.LogError("Unauthorized Access");
                if(context.HttpContext.Request.Headers["X-Requested-With"]=="XMLHttpRequest")
                {
                    context.Result = new StatusCodeResult(401); 
                }
                else
                {
                    context.Result = new RedirectToActionResult("Employee", "Error", new HRManager.Models.ErrorViewModel() { RequestId = "Unauthorized Exception" });
                }
            }

        }
    }
}
