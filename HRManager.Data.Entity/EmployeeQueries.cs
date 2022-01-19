using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;

namespace HRManager.Data.Entity
{
    public class EmployeeQueries
    {
        public EmployeeProfessionalInfo GetProfessionalDetails(int ProfessionalDetailsId)
        {
            return new EmployeeProfessionalInfo();
        }

        public EmployeeShortSummary GetEmployeeShortSummary(int EmployeeId)
        {
            return new EmployeeShortSummary();
        }

    }
}
