using Microsoft.AspNetCore.Mvc;
using HRManager.Business;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using HRManager.Code;
using System.Data;
using System.Text;

using DocumentFormat.OpenXml.Wordprocessing;

namespace HRManager.Controllers
{
    [HRAuthorization("HRAdmin")]
    public class AdminController : Code.BaseController
    {
        public ViewResult Index()
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

        public ViewResult PDValidation()
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

        public ViewResult BGVerification()
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
                var adminManager = new AdminManager();
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

                return PartialView(allEmployeeTable);
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
                var adminManager = new AdminManager();
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

                return PartialView(allEmployeeCards);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult PDValidationPopup(int EmployeeId)
        {
            try
            {
                var pdValidationSummary = new AdminManager().GetEmployeePDValidationSummary(EmployeeId);

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
                var bgVerificationSummary = new AdminManager().GetEmployeeBGVerificationSummary(EmployeeId);

                return PartialView(bgVerificationSummary);
            }
            catch(Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate)
        {
            try
            {
                new AdminManager().SendPDValidationEmail(EmployeeId, FieldsToUpdate);

                return Ok(true);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public IActionResult SendBGVerificationEmail(int ProfessionalDetailsId)
        {
            try
            {
                new AdminManager().SendBGVerificationEmail(ProfessionalDetailsId);

                return Ok(true);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        
    }
}
