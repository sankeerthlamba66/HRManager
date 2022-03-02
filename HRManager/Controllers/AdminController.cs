using Microsoft.AspNetCore.Mvc;
using HRManager.Business;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using HRManager.Code;
using HRManager.Business.BussinessRepository;
using System.Text;
using HRManager.Models.EntityViews;

namespace HRManager.Controllers
{
    [HRAuthorization("HRAdmin")]
    public class AdminController : Code.BaseController
    {
        private readonly IAdminManager adminManager;

        public AdminController(IAdminManager _adminManager)
        {
            adminManager = _adminManager;
        }

        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return ReturnErrorView(ex);
            }
        }
        
        public IActionResult AllEmployeeTable(bool AddVerificationLinks, DateTime? DateFrom, DateTime? DateTo)
        {
            try
            {
                var employeeData = new List<EmployeeTableSummary>();

                if ((DateFrom != null) && (DateTo != null))
                {
                    employeeData = adminManager.GetRecentlyUpdatedEmployees(DateFrom.Value, DateTo.Value);
                }
                else
                {
                    employeeData = adminManager.GetRecentlyUpdatedEmployees();
                }

                var allEmployeeTable = new AllEmployeeTable() { AddVerificationLinks = AddVerificationLinks, EmployeeData = employeeData };

                if (DateFrom != null)
                { allEmployeeTable.FromDate = DateFrom; }

                if (DateTo != null)
                { allEmployeeTable.ToDate = DateTo; }

                if (IsAjaxRequest())
                { return PartialView("_AllEmployeeTable", allEmployeeTable); }
                else
                { return View("_AllEmployeeTable", allEmployeeTable); }
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult AllEmployeeCards(bool AddVerificationLinks, DateTime? DateFrom, DateTime? DateTo)
        {
            try
            {
                var employeeData = new List<EmployeeCardSummary>();

                if ((DateFrom != null) && (DateTo != null))
                {
                    employeeData = adminManager.GetRecentlyUpdatedEmployeeCards(DateFrom.Value, DateTo.Value);
                }
                else
                {
                    employeeData = adminManager.GetRecentlyUpdatedEmployeeCards();
                }

                var allEmployeeCards = new AllEmployeeCards() { AddVerificationLinks = AddVerificationLinks, EmployeeData = employeeData };

                return PartialView("_AllEmployeeCards",allEmployeeCards);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public ViewResult PDValidation(int EmployeeUserId)
        {
            try
            {
                var employeeAllDetails =adminManager.GetEmployeeAllDetails(EmployeeUserId);
                return View(employeeAllDetails);
            }
            catch (Exception ex)
            {
                return ReturnErrorView(ex);
            }
        }

        public ViewResult BGVerification(int EmployeeUserId)
        {
            try
            {
                var employeeAllProfessionalInfo=adminManager.GetEmployeeBGVerificationSummary(EmployeeUserId);
                return View(employeeAllProfessionalInfo);
            }
            catch (Exception ex)
            {
                return ReturnErrorView(ex);
            }
        }

        

        public IActionResult PDValidationPopup(int EmployeeId)
        {
            try
            {
                var pdValidationSummary = adminManager.GetEmployeePDValidationSummary(EmployeeId);
                return PartialView(pdValidationSummary);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult BGVerificationPopup(int EmployeeId)
        {
            try
            {
                var bgVerificationSummary = adminManager.GetEmployeeBGVerificationSummary(EmployeeId);
                return PartialView(bgVerificationSummary);
            }
            catch(Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public IActionResult SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate)
        {
            try
            {
                adminManager.SendPDValidationEmail(EmployeeId, FieldsToUpdate);
                return RedirectToAction("Index");
                //return RedirectToAction("PDValidation",new { EmployeeId = EmployeeId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult SendBGVerificationEmail(int EmployeeUserId,int ProfessionalDetailsId)
        {
            try
            {
                adminManager.SendBGVerificationEmail(ProfessionalDetailsId);
                return RedirectToAction("BGVerification", new {EmployeeUserId= EmployeeUserId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public IActionResult AddEmployee()
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
        public IActionResult AddEmployee(User user)
        {
            try
            {
                user.CreatedBy = Session.UserName;
                adminManager.AddEmployee(user);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public FileResult Export(DateTime? DateFrom, DateTime? DateTo)
        {
            var employeeData = new List<EmployeeTableSummary>();

            if ((DateFrom != null) && (DateTo != null))
            {
                employeeData = adminManager.GetRecentlyUpdatedEmployees(DateFrom.Value, DateTo.Value);
            }
            else
            {
                employeeData = adminManager.GetRecentlyUpdatedEmployees();
            }

            var sb = new StringBuilder();
            sb.AppendLine("Id,EmployeeID,Employee Name,DOB,Mobile No,Personal EmailId,PANCard");
            foreach (var data in employeeData)
            {
                sb.AppendLine(data.Id + ","+data.EmployeeId +","+ data.EmployeeNameAsPerAadhar +","+data.DateOfBirth+ "," +data.MobileNumber+", "+data.PersonalEmailId+","+data.PanCard);
            }
            return File(new UTF8Encoding().GetBytes(sb.ToString()), "text/csv", "export.csv");
        }
        public IActionResult SearchEmployee(string? searchValue)
        {
            try
            {
                var EmployeeData = adminManager.GetRecentlyUpdatedEmployees().Where(s => s.MobileNumber.Contains(searchValue) || s.PersonalEmailId.Contains(searchValue)).ToList();
                var allEmployeeTable = new AllEmployeeTable() { AddVerificationLinks = true, EmployeeData = EmployeeData };
                return PartialView("_AllEmployeeTable", allEmployeeTable);
            }
            catch(Exception ex)
            {
                return HandleException(ex);
            }
        }
    }
}
