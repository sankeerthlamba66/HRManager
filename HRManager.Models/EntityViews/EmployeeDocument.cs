using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace HRManager.Models.EntityViews
{
    public class EmployeeDocument : EntityBase
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        
        [Display(Name = "Passport Photo")]       
        public string PassportPhoto { get; set; }

        [Display(Name = "Resume")]
        public string Resume { get; set; }

        [Display(Name = "Pan Card")]
        public string PanCard { get; set; }

        [Display(Name = "Aadhar Card")]
        public string AadharCard { get; set; }

        [Display(Name = "Passport")]        
        public string Passport { get; set; }

        [Display(Name = "Voter Id")]
        public string VoterId { get; set; }

        [Display(Name = "Current Address Proof")]
        public string CurrentAddressProof { get; set; }

        [Display(Name = "Permanent Address Proof")]
        public string PermanentAddressProof { get; set; }

        [Display(Name = "Father's Aadhar Card")]        
        public string FathersAadharCard { get; set; }

        [Display(Name = "Mother's Aadhar Card")]        
        public string MothersAadharCard { get; set; }
        
        [Display(Name = "Three Months Bank Statement Of Salary Account")]       
        public string ThreeMonthsBankStatementOfSalaryAccount { get; set; }
        
        [Display(Name = "Form 16 Or Income Certificate Of Current Fin Year")]        
        public string Form16OrIncomeCertificateOfCurrentFinYear { get; set; }
        
        [Display(Name = "SSC Or Equivalent")]      
        public string SSCOrEquivalent { get; set; }
        
        [Display(Name = "Intermediate Or Equivalent")]        
        public string IntermediateOrEquivalent { get; set; }
        
        [Display(Name = "Graduation Or Equivalent")]      
        public string GraduationOrEquivalent { get; set; }

        [Display(Name = "PG Or Equivalent ")]        
        public string PGOrEquivalent { get; set; }

        [Display(Name = "Advanced Diploma If Any")]       
        public string AdvancedDiplomaIfAny { get; set; }

        [Display(Name = "Professional Certifications If Any")]
        public string ProfessionalCertificationsIfAny { get; set; }
    }
}
