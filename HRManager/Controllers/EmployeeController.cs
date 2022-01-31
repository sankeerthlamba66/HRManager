using HRManager.Models;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HRManager.Business;
using HRManager.Code;
using HRManager.Business.BussinessRepository;

namespace HRManager.Controllers
{
    
    public class EmployeeController : Code.BaseController
    {
        private readonly IEmployeeManager employeeManager;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeManager _employeeManager)
        {
            _logger = logger;
            employeeManager = _employeeManager;
        }

        [HRAuthorization("Employee")]
        public IActionResult Index()
        {
            EmployeeIndexModels employeeIndexModels = employeeManager.GetEmployeeDetails(Session.UserId);
            return View();
        }

        #region Personal Info
        [HttpGet]
        public IActionResult GetPersonalInfo(int? Id)
        {
            var personalInfo= employeeManager.GetPersonalInfo(Id,Session.UserId);
            return View(personalInfo);
        }

        [HttpPost]
        public IActionResult UpdatePersonalInfo(EmployeePersonalInfo PersonallInfo)
        {
            PersonallInfo.UserId = Session.UserId;
            int UpdatedId = employeeManager.UpdatePersonalInfo(PersonallInfo);
            return RedirectToAction("GetPersonalInfo", new { Id=UpdatedId });
        }
        #endregion

        #region Professional Info
        [HttpGet]
        public IActionResult GetProfessionalInfo(int? Id)
        {
            var professionalInfo = employeeManager.GetProfessionalInfo(Id, Session.UserId);
            return View(professionalInfo);
        }

        [HttpPost]
        public IActionResult AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            ProfessionalInfo.Id = null;
            ProfessionalInfo.UserId = Session.UserId;
            var addedProfessionalInfoId = employeeManager.AddProfessionalInfo(ProfessionalInfo);
            return RedirectToAction("GetProfessionalInfo", new { Id = addedProfessionalInfoId });
        }

        [HttpPost]
        public IActionResult UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            ProfessionalInfo.UserId = Session.UserId;
            var updatedProfessionalId = employeeManager.UpdateProfessionalInfo(ProfessionalInfo);
            return RedirectToAction("GetProfessionalInfo", new { Id = updatedProfessionalId });
        }

        [HttpGet]
        public IActionResult DeleteProfessionalInfo(int Id)
        {
            employeeManager.DeleteProfessionalInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region Bank Info
        public IActionResult GetBankInfo(int? Id)
        {
            var BankInfo = employeeManager.GetBankInfo(Id,Session.UserId);
            return View(BankInfo);
        }

        public IActionResult PostBankInfo(EmployeeBankInfo BankInfo)
        {
            BankInfo.Id = null;
            BankInfo.UserId = Session.UserId;
            var addedBankInfoId = employeeManager.AddBankInfo(BankInfo);
            return RedirectToAction("GetBankInfo", new { Id = addedBankInfoId });
        }

        public IActionResult PutBankInfo(EmployeeBankInfo BankInfo)
        {
            BankInfo.UserId = Session.UserId;
            var updatedBankInfoId = employeeManager.UpdateBankInfo(BankInfo);
            return RedirectToAction("GetBankInfo", new { Id = updatedBankInfoId });
        }

        public IActionResult DeleteBankInfo(int Id)
        {
            employeeManager.DeleteBankInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region Insurance Info
        [HttpGet]
        public IActionResult GetInsuranceInfo(int? Id)
        { 
            var insuranceInfo = employeeManager.GetInsuranceInfo(Id,Session.UserId);
            return View(insuranceInfo);
        }

        [HttpPost]
        public IActionResult AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            InsuranceInfo.Id = null;
            InsuranceInfo.UserId = Session.UserId;
            int addedInsuranceInfoId = employeeManager.AddInsuranceInfo(InsuranceInfo);
            return RedirectToAction("GetInsuranceInfo", new { Id = addedInsuranceInfoId });
        }

        [HttpPost]
        public IActionResult UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            InsuranceInfo.UserId = Session.UserId;
            var updatedInsuranceInfoId = employeeManager.UpdateInsuranceInfo(InsuranceInfo);
            return RedirectToAction("GetInsuranceInfo", new { Id = updatedInsuranceInfoId });
        }

        [HttpGet]
        public IActionResult DeleteInsuranceInfo(int Id)
        {
            employeeManager.DeleteInsuranceInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region PF and ESI Info
        [HttpGet]
        public IActionResult GetPFAndESIInfo(int? Id)
        {
            var PFAndESIInfo = employeeManager.GetPFAndESIInfo(Id,Session.UserId);
            return View(PFAndESIInfo);
        }

        [HttpPost]
        public IActionResult AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            PFAndESIInfo.Id = null;
            PFAndESIInfo.UserId = Session.UserId;
            int addedPFAndESIInfoId = employeeManager.AddPFAndESIInfo(PFAndESIInfo);
            return RedirectToAction("GetPFAndESIInfo", new { Id = addedPFAndESIInfoId });
        }

        [HttpPost]
        public IActionResult UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            PFAndESIInfo.UserId = Session.UserId;
            int updatedPFAndESIInfoId = employeeManager.UpdatePFAndESIInfo(PFAndESIInfo);
            return RedirectToAction("GetPFAndESIInfo", new { Id = updatedPFAndESIInfoId });
        }

        [HttpGet]
        public IActionResult DeletePFAndESIInfo(int Id)
        {
            employeeManager.DeletePFAndESIInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region Documents
        [HttpGet]
        public IActionResult GetDocument(int? Id)
        {
            var document = employeeManager.GetDocument(Id,Session.UserId);
            return View(document);
        }

        [HttpPost]
        public IActionResult AddDocument(EmployeeDocument DocumentInfo)
        {
            DocumentInfo.Id = null;
            DocumentInfo.UserId = Session.UserId;
            int addedDocumentId = employeeManager.AddDocument(DocumentInfo);
            return RedirectToAction("GetDocument", new { Id = addedDocumentId });
        }

        [HttpPost]
        public IActionResult UpdateDocument(EmployeeDocument DocumentInfo)
        {
            DocumentInfo.UserId = Session.UserId;
            int updatedDocumentId = employeeManager.UpdateDocument(DocumentInfo);
            return RedirectToAction("GetDocument", new { Id = updatedDocumentId });
        }

        [HttpGet]
        public IActionResult DeleteDocument(int Id)
        {
            employeeManager.DeleteDocument(Id,Session.UserId);
            return RedirectToAction("Index");
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