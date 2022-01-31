using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.BussinessRepository
{
    public interface IAdminManager
    {
        List<EmployeeTableSummary> GetRecentlyUpdatedEmployees();
        List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo);
        List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards();
        List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo);
        EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId);
        EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId);
        void SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate);
        void SendBGVerificationEmail(int ProfessionalDetailsId);


    }
}
