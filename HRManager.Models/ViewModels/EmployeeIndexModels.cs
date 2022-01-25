using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.ViewModels
{
    public class EmployeeIndexModels
    {
        public EmployeePersonalInfo employeePersonalInfo { get; set; }
        public List<EmployeeProfessionalInfo> employeeProfessionalInfo { get; set; }
        public List<EmployeeBankInfo> employeeBankInfo { get; set; }
        public List<EmployeeDocument> employeeDocument { get; set; }
        public List<EmployeeInsuranceInfo> employeeInsuranceInfo { get; set; }
        public List<EmployeePFandESIInfo> employeePFandESIInfo { get;set; }
    }
}
