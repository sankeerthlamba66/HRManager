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

        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        [Display(Name = "Passport Photo")]       
        public string? PassportPhoto { get; set; }

        [Display(Name = "Resume")]
        [RegularExpression(@"(.pdf)$", ErrorMessage = "File format should be of type pdf")]
        public string? Resume { get; set; }

        [Display(Name = "Pan Card")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? PanCard { get; set; }

        [Display(Name = "Aadhar Card")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? AadharCard { get; set; }

        [Display(Name = "Passport")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? Passport { get; set; }

        [Display(Name = "Voter Id")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? VoterId { get; set; }

        [Display(Name = "Current Address Proof")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? CurrentAddressProof { get; set; }

        [Display(Name = "Permanent Address Proof")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? PermanentAddressProof { get; set; }

        [Display(Name = "Father's Aadhar Card")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? FathersAadharCard { get; set; }

        [Display(Name = "Mother's Aadhar Card")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? MothersAadharCard { get; set; }
        
        [Display(Name = "Three Months Bank Statement Of Salary Account")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? ThreeMonthsBankStatementOfSalaryAccount { get; set; }
        
        [Display(Name = "Form 16 Or Income Certificate Of Current Fin Year")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? Form16OrIncomeCertificateOfCurrentFinYear { get; set; }
        
        [Display(Name = "SSC Or Equivalent")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? SSCOrEquivalent { get; set; }
        
        [Display(Name = "Intermediate Or Equivalent")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? IntermediateOrEquivalent { get; set; }
        
        [Display(Name = "Graduation Or Equivalent")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? GraduationOrEquivalent { get; set; }

        [Display(Name = "PG Or Equivalent ")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? PGOrEquivalent { get; set; }

        [Display(Name = "Advanced Diploma If Any")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? AdvancedDiplomaIfAny { get; set; }

        [Display(Name = "Professional Certifications If Any")]
        [RegularExpression(@"(.png|.jpg|.jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public string? ProfessionalCertificationsIfAny { get; set; }
    }
}
