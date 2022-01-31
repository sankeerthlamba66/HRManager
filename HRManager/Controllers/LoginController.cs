using HRManager.Business;
using HRManager.Business.BussinessRepository;
using HRManager.Code;
using HRManager.Models.EntityViews;
using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    public class LoginController : Code.BaseController
    {
        private readonly ILoginManager loginManager;
        public LoginController(ILoginManager _loginManager)
        {
            loginManager = _loginManager;
        }
        [HttpGet]
        public IActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(User user)
        {
            if (loginManager.CheckUser(user))
            {
                var UserDetails = loginManager.GetUserDetails(user.UserName);
                Session.UserId = Convert.ToInt32(UserDetails.Id);
                Session.UserName = UserDetails.UserName;
                Session.UserRoles = UserDetails.Roles.Split(",").ToList();
                if (UserDetails.Roles.Contains("Employee"))
                {
                    return RedirectToAction("Index", "Employee");
                }
                else if (UserDetails.Roles.Contains("HRAdmin"))
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            return RedirectToAction("Index");
        }


    }
}
