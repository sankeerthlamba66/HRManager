using HRManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRManager.Models.Views
{
    public class EmployeeInfoValidation: EmployeeIndexModels
    {
        public EmployeeInfoValidation()
        {
            this.EmployeeProfessionalInfoValidation = new List<bool>();
            this.EmployeeBankInfoValidation = new List<bool>();
            this.EmployeeInsuranceInfoValidation = new List<bool>();
            this.EmployeePFandESIInfoValidation = new List<bool>();
        }
        public bool EmployeePersonalInfoValidation { get; set; }
        public List<bool> EmployeeProfessionalInfoValidation { get; set; }
        public List<bool> EmployeeBankInfoValidation { get; set; }
        public List<bool> EmployeeInsuranceInfoValidation { get; set; }
        public List<bool> EmployeePFandESIInfoValidation { get; set; }
        public bool EmployeeDocumentInfoValidation { get; set; }



    }
}
