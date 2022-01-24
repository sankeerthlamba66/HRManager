using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;

namespace HRManager.Data.Entity
{
    public class AdminQueries
    {
        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees()
        {
            return new List<EmployeeTableSummary>();
        }

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo)
        {
            return new List<EmployeeTableSummary>();
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards()
        {
            return new List<EmployeeCardSummary>();
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo)
        {
            return new List<EmployeeCardSummary>();
        }

        public EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId)
        {
            return new EmployeePDValidationSummary();
        }

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId)
        {
            return new EmployeeBGVerificationSummary();
        }

        public PDVEmailTemplate GetPDVEmailTemplate()
        {
            return new PDVEmailTemplate();
        }

        public BGVEmailTemplate GetBGVEmailTemplate()
        {
            return new BGVEmailTemplate();
        }

    }
}
