using Microsoft.AspNetCore.Mvc;
using HRManager.Business;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using HRManager.Code;
using HRManager.Business.BussinessRepository;
using System.Text;

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

        public IActionResult Index(DateTime? DateFrom, DateTime? DateTo)
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
        //public IActionResult Index(bool AddVerificationLinks, DateTime? DateFrom, DateTime? DateTo)
        //{
        //    try
        //    {
        //        var employeeData = new List<EmployeeTableSummary>();
        //        if ((DateFrom != null) && (DateTo != null))
        //        {
        //            employeeData = adminManager.GetRecentlyUpdatedEmployees(DateFrom.Value, DateTo.Value);
        //        }
        //        else
        //        {
        //            employeeData = adminManager.GetRecentlyUpdatedEmployees();
        //        }

        //        var allEmployeeTable = new AllEmployeeTable() { AddVerificationLinks = AddVerificationLinks, EmployeeData = employeeData };

        //        return View(allEmployeeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ReturnErrorView(ex);
        //    }
        //}

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

                return PartialView("_AllEmployeeTable", allEmployeeTable);
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
                return Ok(true);
                //return RedirectToAction("PDValidation",new { EmployeeId = EmployeeId });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult SendBGVerificationEmail(int EmployeeId,int ProfessionalDetailsId)
        {
            try
            {
                adminManager.SendBGVerificationEmail(EmployeeId,ProfessionalDetailsId);
                return Ok(true);
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
            foreach (var data in employeeData)
            {
                sb.AppendLine(data.Id + "," + data.EmployeeName + "," +data.MobileNumber+", "+data.PersonalEmailId);
            }
            return File(new UTF8Encoding().GetBytes(sb.ToString()), "text/csv", "export.csv");
        }

    }
}
