using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.EntityRepository
{
    public interface IAdminQueries
    {
        List<EmployeeTableSummary> GetRecentlyUpdatedEmployees();
        List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo);
        List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards();
        List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo);
        EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId);
        EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId);
        PDVEmailTemplate GetPDVEmailTemplate();
        BGVEmailTemplate GetBGVEmailTemplate();

    }
}
