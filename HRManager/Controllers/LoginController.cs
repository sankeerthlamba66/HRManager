using HRManager.Business;
using HRManager.Code;
using HRManager.Models.EntityViews;
using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    public class LoginController : Code.BaseController
    {
        public IActionResult Index(User user)
        {
            if(new LoginManager().CheckUser(user))
            {
                var UserDetails = new LoginManager().GetUserDetails(user.Id);
                Session.UserId = Convert.ToInt32(UserDetails.Id);
                Session.UserName = UserDetails.UserName;
                Session.UserRoles = UserDetails.Roles.Split(",").ToList();
                if (UserDetails.Roles.Contains("Employee"))
                {
                    return RedirectToAction("Index", "Employee");
                }
                else if(UserDetails.Roles.Contains("HRAdmin"))
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View();
            
        }


    }
}
