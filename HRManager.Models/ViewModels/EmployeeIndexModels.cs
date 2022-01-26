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
        public EmployeeIndexModels()
        {
            this.employeePersonalInfo = new EmployeePersonalInfo();
            this.employeeProfessionalInfos = new List<EmployeeProfessionalInfo>();
            this.employeeBankInfos = new List<EmployeeBankInfo>();
            this.employeeInsuranceInfos = new List<EmployeeInsuranceInfo>();
            this.employeePFandESIInfos = new List<EmployeePFandESIInfo>();
            this.employeeDocuments = new List<EmployeeDocument>();
        }
        public EmployeePersonalInfo employeePersonalInfo { get; set; }
        public List<EmployeeProfessionalInfo> employeeProfessionalInfos { get; set; }
        public List<EmployeeBankInfo> employeeBankInfos { get; set; }
        public List<EmployeeInsuranceInfo> employeeInsuranceInfos { get; set; }
        public List<EmployeePFandESIInfo> employeePFandESIInfos { get; set; }
        public List<EmployeeDocument> employeeDocuments { get; set; }
    }
}
