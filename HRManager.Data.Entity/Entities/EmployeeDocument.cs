using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class EmployeeDocument : EntityBase
    {
        public int Id { get; set; }

        public string PassportPhoto { get; set; }
        public string Resume { get; set; }
        public string PanCard { get; set; }
        public string AadharCard { get; set; }
        public string Passport { get; set; }
        public string VoterId { get; set; }
        public string CurrentAddressProof { get; set; }
        public string PermanentAddressProof { get; set; }
        public string FathersAadharCard { get; set; }
        public string MothersAadharCard { get; set; }
        public string ThreeMonthsBankStatementOfSalaryAccount { get; set; }
        public string Form16OrIncomeCertificateOfCurrentFinYear { get; set; }
        public string SSCOrEquivalent { get; set; }
        public string IntermediateOrEquivalent { get; set; }
        public string GraduationOrEquivalent { get; set; }
        public string PGOrEquivalent { get; set; }
        public string AdvancedDiplomaIfAny { get; set; }
        public string ProfessionalCertificationsIfAny { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
