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
            var personalInfo=new EmployeeManager().GetPersonalInfo(Id);
            return View(personalInfo);
        }

        [HttpPost]
        public IActionResult AddPersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            int AddedPersonalInfo = new EmployeeManager().AddPersonalInfo(Session.UserId,PersonalInfo);
            return RedirectToAction("GetPersonalInfo",new { Id = AddedPersonalInfo });
        }

        [HttpPost]
        public IActionResult UpdatePersonalInfo(EmployeePersonalInfo PersoanlInfo)
        {
            int UpdatedId = new EmployeeManager().UpdatePersonalInfo(Session.UserId, PersoanlInfo);
            return RedirectToAction("GetPersonalInfo", new { Id=UpdatedId });
        }

        [HttpGet]
        public IActionResult DeletePersonalInfo(int Id)
        {
            new EmployeeManager().DeletePersonalInfo(Id);
            return RedirectToAction("Index");
        }
        #endregion

        #region Professional Info
        [HttpGet]
        public IActionResult GetProfessionalInfo(int? Id)
        {
            var professionalInfo = new EmployeeManager().GetProfessionalInfo(Id);
            return View(professionalInfo);
        }

        [HttpPost]
        public IActionResult AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            var addedProfessionalInfoId = new EmployeeManager().AddProfessionalInfo(Session.UserId,ProfessionalInfo);
            return RedirectToAction("GetProfessionalInfo", new { Id = addedProfessionalInfoId });
        }

        [HttpPost]
        public IActionResult UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            var updatedProfessionalId = new EmployeeManager().UpdateProfessionalInfo(Session.UserId,ProfessionalInfo);
            return RedirectToAction("GetProfessionalInfo", new { Id = updatedProfessionalId });
        }

        [HttpGet]
        public IActionResult DeleteProfessionalInfo(int Id)
        {
            new EmployeeManager().DeleteProfessionalInfo(Id);
            return RedirectToAction("Index");
        }
        #endregion

        #region Bank Info
        public IActionResult GetBankInfo(int? Id)
        {
            var BankInfo = new EmployeeManager().GetBankInfo(Id);
            return View(BankInfo);
        }

        public IActionResult PostBankInfo(EmployeeBankInfo BankInfo)
        {
            var addedBankInfoId =new EmployeeManager().AddBankInfo(Session.UserId,BankInfo);
            return RedirectToAction("GetBankInfo", new { Id = addedBankInfoId });
        }

        public IActionResult PutBankInfo(EmployeeBankInfo BankInfo)
        {
            var updatedBankInfoId = new EmployeeManager().UpdateBankInfo(Session.UserId, BankInfo);
            return RedirectToAction("GetBankInfo", new { Id = updatedBankInfoId });
        }

        public IActionResult DeleteBankInfo(int Id)
        {
            new EmployeeManager().DeleteBankInfo(Id);
            return RedirectToAction("Index");
        }
        #endregion

        #region Insurance Info
        [HttpGet]
        public IActionResult GetInsuranceInfo(int? Id)
        {
            var insuranceInfo = new EmployeeManager().GetInsuranceInfo(Id);
            return View(insuranceInfo);
        }

        [HttpPost]
        public IActionResult AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            int addedInsuranceInfoId = new EmployeeManager().AddInsuranceInfo(Session.UserId, InsuranceInfo);
            return RedirectToAction("GetInsuranceInfo", new { Id = addedInsuranceInfoId });
        }

        [HttpPost]
        public IActionResult UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            var updatedInsuranceInfoId = new EmployeeManager().UpdateInsuranceInfo(Session.UserId, InsuranceInfo);
            return RedirectToAction("GetInsuranceInfo", new { Id = updatedInsuranceInfoId });
        }

        [HttpGet]
        public IActionResult DeleteInsuranceInfo(int Id)
        {
            new EmployeeManager().DeleteInsuranceInfo(Id);
            return RedirectToAction("Index");
        }
        #endregion

        #region PF and ESI Info
        [HttpGet]
        public IActionResult GetPFAndESIInfo(int? Id)
        {
            var PFAndESIInfo = new EmployeeManager().GetPFAndESIInfo(Id);
            return View(PFAndESIInfo);
        }

        [HttpPost]
        public IActionResult AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            int addedPFAndESIInfoId = new EmployeeManager().AddPFAndESIInfo(Session.UserId, PFAndESIInfo);
            return RedirectToAction("GetPFAndESIInfo", new { Id = addedPFAndESIInfoId });
        }

        [HttpPost]
        public IActionResult UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            int updatedPFAndESIInfoId = new EmployeeManager().UpdatePFAndESIInfo(Session.UserId, PFAndESIInfo);
            return RedirectToAction("GetPFAndESIInfo", new { Id = updatedPFAndESIInfoId });
        }

        [HttpGet]
        public IActionResult DeletePFAndESIInfo(int Id)
        {
            new EmployeeManager().DeletePFAndESIInfo(Id);
            return RedirectToAction("Index");
        }
        #endregion

        #region Documents
        [HttpGet]
        public IActionResult GetDocument(int? Id)
        {
            var document = new EmployeeManager().GetDocument(Id);
            return View(document);
        }

        [HttpPost]
        public IActionResult AddDocument(EmployeeDocument DocumentInfo)
        {
            int addedDocumentId = new EmployeeManager().AddDocument(Session.UserId,DocumentInfo);
            return RedirectToAction("GetDocument", new { Id = addedDocumentId });
        }

        [HttpPost]
        public IActionResult UpdateDocument(EmployeeDocument DocumentInfo)
        {
            int updatedDocumentId = new EmployeeManager().UpdateDocument(Session.UserId, DocumentInfo);
            return RedirectToAction("GetDocument", new { Id = updatedDocumentId });
        }

        [HttpGet]
        public IActionResult DeleteDocumant(int Id)
        {
            new EmployeeManager().DeleteDocumant(Id);
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