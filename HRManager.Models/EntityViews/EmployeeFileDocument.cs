using HRManager.Models.AnnotationHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeeFileDocument : EntityBase
    { 
        public int? Id { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Passport Photo")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PassportPhoto { get; set; }

        [Display(Name = "Resume")]
        [RegularExpression(@"^.*\.(pdf)$", ErrorMessage = "File format should be of type pdf")]
        public IFormFile? Resume { get; set; }

        [Display(Name = "Pan Card")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PanCard { get; set; }

        [Display(Name = "Aadhar Card")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? AadharCard { get; set; }

        [Display(Name = "Passport")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? Passport { get; set; }

        [Display(Name = "Voter Id")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? VoterId { get; set; }

        [Display(Name = "Current Address Proof")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? CurrentAddressProof { get; set; }

        [Display(Name = "Permanent Address Proof")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PermanentAddressProof { get; set; }

        [Display(Name = "Father's Aadhar Card")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? FathersAadharCard { get; set; }

        [Display(Name = "Mother's Aadhar Card")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? MothersAadharCard { get; set; }

        [Display(Name = "Three Months Bank Statement Of Salary Account")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? ThreeMonthsBankStatementOfSalaryAccount { get; set; }

        [Display(Name = "Form 16 Or Income Certificate Of Current Fin Year")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? Form16OrIncomeCertificateOfCurrentFinYear { get; set; }

        [Display(Name = "SSC Or Equivalent")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? SSCOrEquivalent { get; set; }

        [Display(Name = "Intermediate Or Equivalent")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? IntermediateOrEquivalent { get; set; }

        [Display(Name = "Graduation Or Equivalent")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? GraduationOrEquivalent { get; set; }

        [Display(Name = "PG Or Equivalent ")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PGOrEquivalent { get; set; }

        [Display(Name = "Advanced Diploma If Any")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? AdvancedDiplomaIfAny { get; set; }

        [Display(Name = "Professional Certifications If Any")]
        [RegularExpression(@"^.*\.(png|jpg|gif|jpeg)$", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? ProfessionalCertificationsIfAny { get; set; }
    }
}
