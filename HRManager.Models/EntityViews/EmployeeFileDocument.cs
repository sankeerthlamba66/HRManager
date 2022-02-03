using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeeFileDocument
    { 
        public int? Id { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Passport Photo")]
        public IFormFile PassportPhoto { get; set; }

        [Display(Name = "Resume")]
        public IFormFile Resume { get; set; }

        [Display(Name = "Pan Card")]
        public IFormFile PanCard { get; set; }

        [Display(Name = "Aadhar Card")]
        public IFormFile AadharCard { get; set; }

        [Display(Name = "Passport")]
        public IFormFile Passport { get; set; }

        [Display(Name = "Voter Id")]
        public IFormFile VoterId { get; set; }

        [Display(Name = "Current Address Proof")]
        public IFormFile CurrentAddressProof { get; set; }

        [Display(Name = "Permanent Address Proof")]
        public IFormFile PermanentAddressProof { get; set; }

        [Display(Name = "Father's Aadhar Card")]
        public IFormFile FathersAadharCard { get; set; }

        [Display(Name = "Mother's Aadhar Card")]
        public IFormFile MothersAadharCard { get; set; }

        [Display(Name = "Three Months Bank Statement Of Salary Account")]
        public IFormFile ThreeMonthsBankStatementOfSalaryAccount { get; set; }

        [Display(Name = "Form 160r Income Certificate Of Current Fin Year")]
        public IFormFile Form16OrIncomeCertificateOfCurrentFinYear { get; set; }

        [Display(Name = "SSC Or Equivalent")]
        public IFormFile SSCOrEquivalent { get; set; }

        [Display(Name = "Intermediate Or Equivalent")]
        public IFormFile IntermediateOrEquivalent { get; set; }

        [Display(Name = "Graduation Or Equivalent")]
        public IFormFile GraduationOrEquivalent { get; set; }

        [Display(Name = "PG Or Equivalent ")]
        public IFormFile PGOrEquivalent { get; set; }

        [Display(Name = "Advanced Diploma If Any")]
        public IFormFile AdvancedDiplomaIfAny { get; set; }

        [Display(Name = "Professional Certifications If Any")]
        public IFormFile ProfessionalCertificationsIfAny { get; set; }
    }
}
