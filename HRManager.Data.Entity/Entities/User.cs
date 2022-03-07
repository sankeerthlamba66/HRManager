using HRManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class User : EntityBase
    {
        public int Id { get; set; }
        public string UserMailId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string MobileNumber { get; set; }

        public byte OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        public ICollection<EmployeeBankInfo> BankInfos { get; set; }
        public ICollection<EmployeeDocument> Documents { get; set; }
        public ICollection<EmployeeInsuranceInfo> InsuranceInfos { get; set; }
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public ICollection<EmployeePFandESIInfo> PFandESIInfos { get; set; }
        public ICollection<EmployeeProfessionalInfo> ProfessionalInfos { get; set; }
        public Validation Validation { get; set; }
    }
}
