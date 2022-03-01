﻿using Microsoft.AspNetCore.Http;
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
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PassportPhoto { get; set; }

        [Display(Name = "Resume")]
        [FileExtensions(Extensions = "pdf", ErrorMessage = "File format should be of type pdf")]
        public IFormFile? Resume { get; set; }

        [Display(Name = "Pan Card")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PanCard { get; set; }

        [Display(Name = "Aadhar Card")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? AadharCard { get; set; }

        [Display(Name = "Passport")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? Passport { get; set; }

        [Display(Name = "Voter Id")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? VoterId { get; set; }

        [Display(Name = "Current Address Proof")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? CurrentAddressProof { get; set; }

        [Display(Name = "Permanent Address Proof")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? PermanentAddressProof { get; set; }

        [Display(Name = "Father's Aadhar Card")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? FathersAadharCard { get; set; }

        [Display(Name = "Mother's Aadhar Card")]
        [FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = "File format should be of type jpg,jpeg,png")]
        public IFormFile? MothersAadharCard { get; set; }

        [Display(Name = "Three Months Bank Statement Of Salary Account")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? ThreeMonthsBankStatementOfSalaryAccount { get; set; }

        [Display(Name = "Form 16 Or Income Certificate Of Current Fin Year")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? Form16OrIncomeCertificateOfCurrentFinYear { get; set; }

        [Display(Name = "SSC Or Equivalent")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? SSCOrEquivalent { get; set; }

        [Display(Name = "Intermediate Or Equivalent")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? IntermediateOrEquivalent { get; set; }

        [Display(Name = "Graduation Or Equivalent")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? GraduationOrEquivalent { get; set; }

        [Display(Name = "PG Or Equivalent ")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? PGOrEquivalent { get; set; }

        [Display(Name = "Advanced Diploma If Any")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? AdvancedDiplomaIfAny { get; set; }

        [Display(Name = "Professional Certifications If Any")]
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? ProfessionalCertificationsIfAny { get; set; }
    }
}
