using HRManager.Models.EntityViews;
using HRManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.Views
{
    public class EmployeeBGVerificationSummary
    {
        public EmployeeBGVerificationSummary()
        {
            this.professionalDetails = new List<EmployeeProfessionalInfo>();
            this.personalDetails=new EmployeePersonalInfo();
        }
        public List<EmployeeProfessionalInfo> professionalDetails { get; set; }       
        public EmployeePersonalInfo personalDetails { get; set; }
        public string Name { get; set; }
    }
}
