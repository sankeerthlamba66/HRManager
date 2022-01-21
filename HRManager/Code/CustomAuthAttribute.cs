using HRManager.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HRManager.Code
{
    public class CustomAuthAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string[] allowedroles;

        public CustomAuthAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = new AdminManager().GetRoles(allowedroles, Session.UserId, Session.UserName);
            if (string.IsNullOrEmpty(user))
            {
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            else { Session.UserRoles = user.Split(",").ToList(); }
        }
        
    }
}
