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
    [HRAuthorization("Employee")]
    public class EmployeeController : Code.BaseController
    {
        private readonly IEmployeeManager employeeManager;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeManager _employeeManager, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
            employeeManager = _employeeManager;
        }

        public IActionResult Index()
        {
            try
            {
                EmployeeIndexModels employeeIndexModels = employeeManager.GetEmployeeDetails(Session.UserId);
                return View(employeeIndexModels);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        #region Personal Info
        [HttpGet]
        public IActionResult GetPersonalInfo(int? Id)
        {
            try
            {
                var personalInfo = employeeManager.GetPersonalInfo(Id, Session.UserId);
                return View(personalInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult UpdatePersonalInfo()
        {
            try
            {
                var personalInfo = employeeManager.GetPersonalInfo(Session.UserId);
                return View(personalInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }

        }
        [HttpPost]
        public IActionResult UpdatePersonalInfo(EmployeePersonalInfo PersonallInfo)
        {
            try
            {
                PersonallInfo.UserId = Session.UserId;
                int UpdatedId = employeeManager.UpdatePersonalInfo(PersonallInfo);
                return RedirectToAction("GetPersonalInfo", new { Id = UpdatedId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        #endregion

        #region Professional Info
        [HttpGet]
        public IActionResult GetProfessionalInfo(int? Id)
        {
            try
            {
                var professionalInfo = employeeManager.GetProfessionalInfo(Id, Session.UserId);
                return View(professionalInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpGet]
        public IActionResult AddProfessionalInfo()
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
        public IActionResult AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            try
            {
                ProfessionalInfo.Id = null;
                ProfessionalInfo.UserId = Session.UserId;
                var addedProfessionalInfoId = employeeManager.AddProfessionalInfo(ProfessionalInfo);
                return RedirectToAction("GetProfessionalInfo", new { Id = addedProfessionalInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult UpdateProfessionalInfo()
        {
            try
            {
                var professionalInfo = employeeManager.GetProfessionalInfo(Session.UserId);
                return View(professionalInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            try
            {
                ProfessionalInfo.UserId = Session.UserId;
                var updatedProfessionalId = employeeManager.UpdateProfessionalInfo(ProfessionalInfo);
                return RedirectToAction("GetProfessionalInfo", new { Id = updatedProfessionalId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult DeleteProfessionalInfo(int Id)
        {
            try
            {
                employeeManager.DeleteProfessionalInfo(Id, Session.UserId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        #endregion

        #region Bank Info
        public IActionResult GetBankInfo(int? Id)
        {
            try
            {
                var BankInfo = employeeManager.GetBankInfo(Id, Session.UserId);
                return View(BankInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult PostBankInfo(EmployeeBankInfo BankInfo)
        {
            try
            {
                BankInfo.Id = null;
                BankInfo.UserId = Session.UserId;
                var addedBankInfoId = employeeManager.AddBankInfo(BankInfo);
                return RedirectToAction("GetBankInfo", new { Id = addedBankInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult PutBankInfo()
        {
            try
            {
                var BankInfoList = employeeManager.GetBankInfo(Session.UserId);
                return View(BankInfoList);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult PutBankInfo(EmployeeBankInfo BankInfo)
        {
            try
            {
                BankInfo.UserId = Session.UserId;
                var updatedBankInfoId = employeeManager.UpdateBankInfo(BankInfo);
                return RedirectToAction("GetBankInfo", new { Id = updatedBankInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult DeleteBankInfo(int Id)
        {
            try
            {
                employeeManager.DeleteBankInfo(Id, Session.UserId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        #endregion

        #region Insurance Info
        [HttpGet]
        public IActionResult GetInsuranceInfo(int? Id)
        {
            try
            {
                var insuranceInfo = employeeManager.GetInsuranceInfo(Id, Session.UserId);
                return View(insuranceInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            try
            {
                InsuranceInfo.Id = null;
                InsuranceInfo.UserId = Session.UserId;
                int addedInsuranceInfoId = employeeManager.AddInsuranceInfo(InsuranceInfo);
                return RedirectToAction("GetInsuranceInfo", new { Id = addedInsuranceInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult UpdateInsuranceInfo()
        {
            try
            {
                var insuranceInfo = employeeManager.GetInsuranceInfo( Session.UserId);
                return View(insuranceInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            try
            {
                InsuranceInfo.UserId = Session.UserId;
                var updatedInsuranceInfoId = employeeManager.UpdateInsuranceInfo(InsuranceInfo);
                return RedirectToAction("GetInsuranceInfo", new { Id = updatedInsuranceInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult DeleteInsuranceInfo(int Id)
        {
            try
            {
                employeeManager.DeleteInsuranceInfo(Id, Session.UserId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        #endregion

        #region PF and ESI Info
        [HttpGet]
        public IActionResult GetPFAndESIInfo(int? Id)
        {
            try
            {
                var PFAndESIInfo = employeeManager.GetPFAndESIInfo(Id, Session.UserId);
                return View(PFAndESIInfo);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            try
            {
                PFAndESIInfo.Id = null;
                PFAndESIInfo.UserId = Session.UserId;
                int addedPFAndESIInfoId = employeeManager.AddPFAndESIInfo(PFAndESIInfo);
                return RedirectToAction("GetPFAndESIInfo", new { Id = addedPFAndESIInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpGet]
        public IActionResult UpdatePFAndESIInfo()
        {
            try
            {
                var PFAndESIInfoList = employeeManager.GetPFAndESIInfo(Session.UserId);
                return View(PFAndESIInfoList);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            try
            {
                PFAndESIInfo.UserId = Session.UserId;
                int updatedPFAndESIInfoId = employeeManager.UpdatePFAndESIInfo(PFAndESIInfo);
                return RedirectToAction("GetPFAndESIInfo", new { Id = updatedPFAndESIInfoId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult DeletePFAndESIInfo(int Id)
        {
            try
            {
                employeeManager.DeletePFAndESIInfo(Id, Session.UserId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        #endregion

        #region Documents
        [HttpGet]
        public IActionResult GetDocument(int? Id)
        {
            try
            {
                var document = employeeManager.GetDocument(Id, Session.UserId);
                return View(document);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult AddDocument(EmployeeFileDocument DocumentInfo)
        {
            try
            {
                EmployeeDocument employeeDocument = new EmployeeDocument();
                employeeDocument.Id = null;
                employeeDocument.UserId = Session.UserId;
                if (DocumentInfo.PassportPhoto != null)
                { employeeDocument.PassportPhoto = Code.FileManager.UploadDocument(DocumentInfo.PassportPhoto, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.Resume != null)
                { employeeDocument.Resume = Code.FileManager.UploadDocument(DocumentInfo.Resume, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.PanCard != null)
                { employeeDocument.PanCard = Code.FileManager.UploadDocument(DocumentInfo.PanCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.AadharCard != null)
                { employeeDocument.AadharCard = Code.FileManager.UploadDocument(DocumentInfo.AadharCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.Passport != null)
                { employeeDocument.Passport = Code.FileManager.UploadDocument(DocumentInfo.Passport, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.VoterId != null)
                { employeeDocument.VoterId = Code.FileManager.UploadDocument(DocumentInfo.VoterId, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.CurrentAddressProof != null)
                { employeeDocument.CurrentAddressProof = Code.FileManager.UploadDocument(DocumentInfo.CurrentAddressProof, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.PermanentAddressProof != null)
                { employeeDocument.PermanentAddressProof = Code.FileManager.UploadDocument(DocumentInfo.PermanentAddressProof, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.FathersAadharCard != null)
                { employeeDocument.FathersAadharCard = Code.FileManager.UploadDocument(DocumentInfo.FathersAadharCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.MothersAadharCard != null)
                { employeeDocument.MothersAadharCard = Code.FileManager.UploadDocument(DocumentInfo.MothersAadharCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount != null)
                { employeeDocument.ThreeMonthsBankStatementOfSalaryAccount = Code.FileManager.UploadDocument(DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear != null)
                { employeeDocument.Form16OrIncomeCertificateOfCurrentFinYear = Code.FileManager.UploadDocument(DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.SSCOrEquivalent != null)
                { employeeDocument.SSCOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.SSCOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.IntermediateOrEquivalent != null)
                { employeeDocument.IntermediateOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.IntermediateOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.GraduationOrEquivalent != null)
                { employeeDocument.GraduationOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.GraduationOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.PGOrEquivalent != null)
                { employeeDocument.PGOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.PGOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.AdvancedDiplomaIfAny != null)
                { employeeDocument.AdvancedDiplomaIfAny = Code.FileManager.UploadDocument(DocumentInfo.AdvancedDiplomaIfAny, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.ProfessionalCertificationsIfAny != null)
                { employeeDocument.ProfessionalCertificationsIfAny = Code.FileManager.UploadDocument(DocumentInfo.ProfessionalCertificationsIfAny, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                int addedDocumentId = employeeManager.AddDocument(employeeDocument);
                return RedirectToAction("GetDocument", new { Id = addedDocumentId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpGet]
        public IActionResult UpdateDocument()
        {
            try
            {
                var document = employeeManager.GetDocument(Session.UserId);
                return View(document);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult UpdateDocument(EmployeeFileDocument DocumentInfo)
        {
            try
            {
                EmployeeDocument employeeDocument = new EmployeeDocument();
                employeeDocument.UserId = Session.UserId;
                if (DocumentInfo.PassportPhoto != null)
                { employeeDocument.PassportPhoto = Code.FileManager.UploadDocument(DocumentInfo.PassportPhoto, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.Resume != null)
                { employeeDocument.Resume = Code.FileManager.UploadDocument(DocumentInfo.Resume, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.PanCard != null)
                { employeeDocument.PanCard = Code.FileManager.UploadDocument(DocumentInfo.PanCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.AadharCard != null)
                { employeeDocument.AadharCard = Code.FileManager.UploadDocument(DocumentInfo.AadharCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.Passport != null)
                { employeeDocument.Passport = Code.FileManager.UploadDocument(DocumentInfo.Passport, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.VoterId != null)
                { employeeDocument.VoterId = Code.FileManager.UploadDocument(DocumentInfo.VoterId, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.CurrentAddressProof != null)
                { employeeDocument.CurrentAddressProof = Code.FileManager.UploadDocument(DocumentInfo.CurrentAddressProof, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.PermanentAddressProof != null)
                { employeeDocument.PermanentAddressProof = Code.FileManager.UploadDocument(DocumentInfo.PermanentAddressProof, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.FathersAadharCard != null)
                { employeeDocument.FathersAadharCard = Code.FileManager.UploadDocument(DocumentInfo.FathersAadharCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.MothersAadharCard != null)
                { employeeDocument.MothersAadharCard = Code.FileManager.UploadDocument(DocumentInfo.MothersAadharCard, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount != null)
                { employeeDocument.ThreeMonthsBankStatementOfSalaryAccount = Code.FileManager.UploadDocument(DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear != null)
                { employeeDocument.Form16OrIncomeCertificateOfCurrentFinYear = Code.FileManager.UploadDocument(DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.SSCOrEquivalent != null)
                { employeeDocument.SSCOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.SSCOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.IntermediateOrEquivalent != null)
                { employeeDocument.IntermediateOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.IntermediateOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.GraduationOrEquivalent != null)
                { employeeDocument.GraduationOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.GraduationOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.PGOrEquivalent != null)
                { employeeDocument.PGOrEquivalent = Code.FileManager.UploadDocument(DocumentInfo.PGOrEquivalent, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.AdvancedDiplomaIfAny != null)
                { employeeDocument.AdvancedDiplomaIfAny = Code.FileManager.UploadDocument(DocumentInfo.AdvancedDiplomaIfAny, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                if (DocumentInfo.ProfessionalCertificationsIfAny != null)
                { employeeDocument.ProfessionalCertificationsIfAny = Code.FileManager.UploadDocument(DocumentInfo.ProfessionalCertificationsIfAny, Path.Combine(_webHostEnvironment.WebRootPath, "/Documents")); }
                int updatedDocumentId = employeeManager.UpdateDocument(employeeDocument);
                return RedirectToAction("GetDocument", new { Id = updatedDocumentId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult DeleteDocument(int Id)
        {
            try
            {
                employeeManager.DeleteDocument(Id, Session.UserId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        #endregion

        #region Miscellaneous
        public IActionResult Privacy()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}