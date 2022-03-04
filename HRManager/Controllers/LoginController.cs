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
                    var UserDetails = loginManager.GetUserDetails(loginUser.UserMailId);
                    Session.UserId = Convert.ToInt32(UserDetails.Id);
                    Session.UserName = UserDetails.UserName;
                    Session.UserMailId = UserDetails.UserMailId;
                    Session.UserRoles = UserDetails.Roles.Split(",").ToList();
                    Session.OrganizationId = UserDetails.OrganizationId;
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
            try
            {
                HttpContext.Session.Clear();
                // Redirecting to Login page after deleting Session
                return RedirectToAction("Index");
            }
            catch(Exception ex) 
            {
                return HandleException(ex);
            }
        }


    }
}
