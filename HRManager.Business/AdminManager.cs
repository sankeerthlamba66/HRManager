using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using HRManager.Data.Entity;
using HRManager.Business.BussinessRepository;
using HRManager.Data.Entity.EntityRepository;

namespace HRManager.Business
{
    public class AdminManager:IAdminManager
    {
        private readonly IAdminQueries adminQueries;
        private readonly IEmployeeQueries employeeQueries;
        public AdminManager(IAdminQueries _adminQueries, IEmployeeQueries _employeeQueries)
        {
            adminQueries = _adminQueries;
            employeeQueries = _employeeQueries;
        }
        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees()
        {
            return adminQueries.GetRecentlyUpdatedEmployees();
        }

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo)
        {
            return adminQueries.GetRecentlyUpdatedEmployees(DateFrom, DateTo);
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards()
        {
            return adminQueries.GetRecentlyUpdatedEmployeeCards();
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo)
        {
            return adminQueries.GetRecentlyUpdatedEmployeeCards(DateFrom, DateTo);
        }

        public EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId)
        {
            return adminQueries.GetEmployeePDValidationSummary(EmployeeId);
        }

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId)
        {
            return adminQueries.GetEmployeeBGVerificationSummary(EmployeeId);
        }

        public void SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate)
        {
            var Summary = employeeQueries.GetEmployeeShortSummary(EmployeeId);
            var EmailTemplate = adminQueries.GetPDVEmailTemplate();

            //Substitute placeholders in the templates with the employee details and Fields List.
            string Subject = string.Empty;
            string Body = string.Empty;

            Helpers.Utilities.SendEmail(Summary.Email, Subject, Body);
        }

        public void SendBGVerificationEmail(int ProfessionalDetailsId)
        {
            var ProfDetails = employeeQueries.GetProfessionalDetails(ProfessionalDetailsId);
            var EmailTemplate = adminQueries.GetBGVEmailTemplate();

            //Substitute placeholders in the templates with the professional details.
            string Subject = string.Empty;
            string Body = string.Empty;

            Helpers.Utilities.SendEmail(ProfDetails.ReferenceEmailId, Subject, Body);
        }
    }
}
