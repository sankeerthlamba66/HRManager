using HRManager.Business;
using HRManager.Business.BussinessRepository;
using HRManager.Code;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
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
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult LogIn(LoginUser loginUser)
        {
            try
            {
                if (loginManager.CheckUser(loginUser))
                {
                    var UserDetails = loginManager.GetUserDetails(loginUser.UserName);
                    Session.UserId = (int)UserDetails.Id;
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
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public ActionResult LogOut()
        {
            Session.UserRoles.Clear();
            // Redirecting to Login page after deleting Session
            return RedirectToAction("Index", "Login");
        }


    }
}
