using HRManager.Models;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRManager.Controllers
{
    public class EmployeeController : Code.BaseController
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Personal Info
        [HttpGet]
        public IActionResult GetPersonalInfo(int? Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPersonalInfo(EmployeePersonalInfo PersoanlInfo)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdatePersonalInfo(EmployeePersonalInfo PersoanlInfo)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeletePersonalInfo(int Id)
        {
            return View();
        }
        #endregion

        #region Professional Info
        [HttpGet]
        public IActionResult GetProfessionalInfo(int? Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteProfessionalInfo(int Id)
        {
            return View();
        }
        #endregion

        #region Bank Info
        public IActionResult GetBankInfo(int? Id)
        {
            return View();
        }

        public IActionResult PostBankInfo(EmployeeBankInfo BankInfo)
        {
            return View();
        }

        public IActionResult PutBankInfo(EmployeeBankInfo BankInfo)
        {
            return View();
        }

        public IActionResult DeleteBankInfo(int Id)
        {
            return View();
        }
        #endregion

        #region Insurance Info
        [HttpGet]
        public IActionResult GetInsuranceInfo(int? Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteInsuranceInfo(int Id)
        {
            return View();
        }
        #endregion

        #region PF and ESI Info
        [HttpGet]
        public IActionResult GetPFAndESIInfo(int? Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeletePFAndESIInfo(int Id)
        {
            return View();
        }
        #endregion

        #region Documents
        [HttpGet]
        public IActionResult GetDocumant(int? Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDocumant(EmployeeDocument DocumentInfo)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateDocumant(EmployeeDocument DocumentInfo)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteDocumant(int Id)
        {
            return View();
        }
        #endregion

        #region Miscellaneous
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}