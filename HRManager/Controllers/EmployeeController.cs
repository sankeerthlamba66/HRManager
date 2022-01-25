using HRManager.Models;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HRManager.Business;
using HRManager.Code;

namespace HRManager.Controllers
{
    [HRAuthorization("Employee")]
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
            var personalInfo=new EmployeeManager().GetPersonalInfo(Id,Session.UserId);
            return View(personalInfo);
        }

        [HttpPost]
        public IActionResult UpdatePersonalInfo(EmployeePersonalInfo PersonallInfo)
        {
            PersonallInfo.Id = null;
            PersonallInfo.UserId = Session.UserId;
            int UpdatedId = new EmployeeManager().UpdatePersonalInfo(PersonallInfo);
            return RedirectToAction("GetPersonalInfo", new { Id=UpdatedId });
        }
        #endregion

        #region Professional Info
        [HttpGet]
        public IActionResult GetProfessionalInfo(int? Id)
        {
            var professionalInfo = new EmployeeManager().GetProfessionalInfo(Id, Session.UserId);
            return View(professionalInfo);
        }

        [HttpPost]
        public IActionResult AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            ProfessionalInfo.Id = null;
            ProfessionalInfo.UserId = Session.UserId;
            var addedProfessionalInfoId = new EmployeeManager().AddProfessionalInfo(ProfessionalInfo);
            return RedirectToAction("GetProfessionalInfo", new { Id = addedProfessionalInfoId });
        }

        [HttpPost]
        public IActionResult UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            ProfessionalInfo.Id = null;
            ProfessionalInfo.UserId = Session.UserId;
            var updatedProfessionalId = new EmployeeManager().UpdateProfessionalInfo(ProfessionalInfo);
            return RedirectToAction("GetProfessionalInfo", new { Id = updatedProfessionalId });
        }

        [HttpGet]
        public IActionResult DeleteProfessionalInfo(int Id)
        {
            new EmployeeManager().DeleteProfessionalInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region Bank Info
        public IActionResult GetBankInfo(int? Id)
        {
            var BankInfo = new EmployeeManager().GetBankInfo(Id,Session.UserId);
            return View(BankInfo);
        }

        public IActionResult PostBankInfo(EmployeeBankInfo BankInfo)
        {
            BankInfo.Id = null;
            BankInfo.UserId = Session.UserId;
            var addedBankInfoId =new EmployeeManager().AddBankInfo(BankInfo);
            return RedirectToAction("GetBankInfo", new { Id = addedBankInfoId });
        }

        public IActionResult PutBankInfo(EmployeeBankInfo BankInfo)
        {
            BankInfo.Id = null;
            BankInfo.UserId = Session.UserId;
            var updatedBankInfoId = new EmployeeManager().UpdateBankInfo(BankInfo);
            return RedirectToAction("GetBankInfo", new { Id = updatedBankInfoId });
        }

        public IActionResult DeleteBankInfo(int Id)
        {
            new EmployeeManager().DeleteBankInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region Insurance Info
        [HttpGet]
        public IActionResult GetInsuranceInfo(int? Id)
        { 
            var insuranceInfo = new EmployeeManager().GetInsuranceInfo(Id,Session.UserId);
            return View(insuranceInfo);
        }

        [HttpPost]
        public IActionResult AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            InsuranceInfo.Id = null;
            InsuranceInfo.UserId = Session.UserId;
            int addedInsuranceInfoId = new EmployeeManager().AddInsuranceInfo(InsuranceInfo);
            return RedirectToAction("GetInsuranceInfo", new { Id = addedInsuranceInfoId });
        }

        [HttpPost]
        public IActionResult UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            InsuranceInfo.Id = null;
            InsuranceInfo.UserId = Session.UserId;
            var updatedInsuranceInfoId = new EmployeeManager().UpdateInsuranceInfo(InsuranceInfo);
            return RedirectToAction("GetInsuranceInfo", new { Id = updatedInsuranceInfoId });
        }

        [HttpGet]
        public IActionResult DeleteInsuranceInfo(int Id)
        {
            new EmployeeManager().DeleteInsuranceInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region PF and ESI Info
        [HttpGet]
        public IActionResult GetPFAndESIInfo(int? Id)
        {
            var PFAndESIInfo = new EmployeeManager().GetPFAndESIInfo(Id,Session.UserId);
            return View(PFAndESIInfo);
        }

        [HttpPost]
        public IActionResult AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            PFAndESIInfo.Id = null;
            PFAndESIInfo.UserId = Session.UserId;
            int addedPFAndESIInfoId = new EmployeeManager().AddPFAndESIInfo(PFAndESIInfo);
            return RedirectToAction("GetPFAndESIInfo", new { Id = addedPFAndESIInfoId });
        }

        [HttpPost]
        public IActionResult UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            PFAndESIInfo.Id = null;
            PFAndESIInfo.UserId = Session.UserId;
            int updatedPFAndESIInfoId = new EmployeeManager().UpdatePFAndESIInfo(PFAndESIInfo);
            return RedirectToAction("GetPFAndESIInfo", new { Id = updatedPFAndESIInfoId });
        }

        [HttpGet]
        public IActionResult DeletePFAndESIInfo(int Id)
        {
            new EmployeeManager().DeletePFAndESIInfo(Id,Session.UserId);
            return RedirectToAction("Index");
        }
        #endregion

        #region Documents
        [HttpGet]
        public IActionResult GetDocument(int? Id)
        {
            var document = new EmployeeManager().GetDocument(Id,Session.UserId);
            return View(document);
        }

        [HttpPost]
        public IActionResult AddDocument(EmployeeDocument DocumentInfo)
        {
            DocumentInfo.Id = null;
            DocumentInfo.UserId = Session.UserId;
            int addedDocumentId = new EmployeeManager().AddDocument(DocumentInfo);
            return RedirectToAction("GetDocument", new { Id = addedDocumentId });
        }

        [HttpPost]
        public IActionResult UpdateDocument(EmployeeDocument DocumentInfo)
        {
            DocumentInfo.Id = null;
            DocumentInfo.UserId = Session.UserId;
            int updatedDocumentId = new EmployeeManager().UpdateDocument(DocumentInfo);
            return RedirectToAction("GetDocument", new { Id = updatedDocumentId });
        }

        [HttpGet]
        public IActionResult DeleteDocument(int Id)
        {
            new EmployeeManager().DeleteDocument(Id,Session.UserId);
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