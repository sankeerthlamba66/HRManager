using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
