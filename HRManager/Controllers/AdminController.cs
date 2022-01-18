using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
