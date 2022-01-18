using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AllEmployeeDetails()
        {
            return View();
        }
        public PartialViewResult AllEmployeeTable()
        {
            return PartialView();
        }

        public PartialViewResult AllEmployeeCards()
        {
            return PartialView();
        }
    }
}
